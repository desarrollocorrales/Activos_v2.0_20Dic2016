using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Activos.Datos
{
    public class ResponsivasDatos : IResponsivasDatos
    {
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexion;

        public ResponsivasDatos()
        {
            // Establece la cadena de conexión
            _conexion = new Conexion(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        }

        // crea responsivas
        public long crearResponsivas(int idUsuarioCreador, int? idUsuario, string observaciones)
        {
            long result = 0;

            string sql =
                "INSERT INTO activos_responsivas(idusuario, idusuariocrea, observaciones, status) " +
                "VALUES (@idUs, @idUsCrea, @observ, 'A')";

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idUs", idUsuario);
                    cmd.Parameters.AddWithValue("@idUsCrea", idUsuarioCreador);
                    cmd.Parameters.AddWithValue("@observ", observaciones);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = 0;
                        else result = cmd.LastInsertedId;
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);
                }
            }

            return result;
        }

        // crea la responsiva
        public bool creaRespDet(long idResp, List<Modelos.Activos> activos)
        {
            bool result = false;

            string sql =
                "INSERT INTO activos_responsivasdetalle(idresponsiva, idactivo, costo, status) " +
                "VALUES (@idResp, @idActivo, @costo, 'A')";

            int rows = 0;
            string error = string.Empty;

            List<long> ids = new List<long>();

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();
                foreach (Modelos.Activos activo in activos)
                {
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;

                        // define parametros
                        cmd.Parameters.AddWithValue("@idResp", idResp);
                        cmd.Parameters.AddWithValue("@idActivo", activo.idActivo);
                        cmd.Parameters.AddWithValue("@costo", activo.costo == null ? (object)DBNull.Value : activo.costo.ToString());

                        ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                        if (res.ok)
                        {
                            if (rows == 0) result = false;
                            else { ids.Add(cmd.LastInsertedId); result = true; }
                        }
                        else
                        {
                            error = res.numErr + ": " + res.descErr;
                            break;
                        }
                    }
                }

                if (!string.IsNullOrEmpty(error))
                {
                    using (var cmd = new MySqlCommand())
                    {
                        string sqlD = string.Format("delete from activos_responsivasdetalle where idresposivadet in ({0})", (ids.Count == 0 ? "0" : string.Join(",", ids)));
                        string sqlR = string.Format("delete from activos_responsivas where idresponsiva = {0}", idResp);
                        cmd.Connection = conn;

                        int rows2 = 0;

                        Utilerias.EjecutaSQL(sqlD, ref rows2, cmd);

                        Utilerias.EjecutaSQL(sqlR, ref rows2, cmd);

                    }

                    throw new Exception(error);
                }
            }

            return result;
        }

        // consulta las responsivas por sucursal y nombre
        public List<Responsivas> buscaResponsiva(string responsable, int idSuc)
        {
            List<Responsivas> result = new List<Responsivas>();
            Responsivas ent;

            string sql =
                        "select r.idresponsiva, r.idusuario, r.fecha, r.idusuariocrea, r.observaciones, r.fechabaja, r.status, " +
                        "p.nombrecompleto, " +
                        "pu.nombre as puesto, " +
                        "s.nombre as sucursal " +
                        "from activos_responsivas r " +
                        "left join activos_usuarios u on (r.idusuario = u.idusuario) " +
                        "left join activos_personas p on (u.idpersona = p.idpersona) " +
                        "left join activos_puesto pu on (p.idpuesto = pu.idpuesto) " +
                        "left join activos_sucursales s on (pu.idsucursal = s.idsucursal) " +
                        "left join activos_responsivasdetalle rd on (r.idresponsiva = rd.idresponsiva) " +
                        "where s.idsucursal = @isSucursal and p.nombrecompleto LIKE @nomb and rd.status != 'B' " +
                        "group by r.idresponsiva, r.idusuario, r.fecha, r.idusuariocrea, r.observaciones, r.fechabaja, r.status, " +
                        "p.nombrecompleto, pu.nombre, s.nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nomb", responsable.Equals("&") ? "" : "%" + responsable + "%");
                    cmd.Parameters.AddWithValue("@isSucursal", idSuc);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Responsivas();

                            ent.idResponsiva = Convert.ToInt16(res.reader["idresponsiva"]);
                            ent.idUsuario = Convert.ToInt16(res.reader["idusuario"]);
                            ent.idUsuarioCrea = Convert.ToInt16(res.reader["idusuariocrea"]);
                            
                            ent.fecha = Convert.ToString(res.reader["fecha"]);
                            ent.observaciones = Convert.ToString(res.reader["observaciones"]);
                            ent.fechaBaja = Convert.ToString(res.reader["fechabaja"]);
                            ent.status = Convert.ToString(res.reader["status"]);

                            ent.puesto = Convert.ToString(res.reader["puesto"]);
                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);
                            ent.responsable = Convert.ToString(res.reader["nombrecompleto"]).Replace("&", " ").Trim();
                            
                            ent.status = string.Empty;

                            result.Add(ent);
                        }
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }



            return result;
        }

        // modifica una responsiva
        public bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos)
        {
            MySqlTransaction trans;

            bool result = true;

            string sql = string.Empty;

            int rows = 0;
            string error = string.Empty;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();
                using (var cmd = new MySqlCommand())
                {

                    trans = conn.BeginTransaction();

                    cmd.Connection = conn;
                    cmd.Transaction = trans;

                    cmd.Parameters.Clear();

                    foreach (Modelos.Activos activo in activosMtos)
                    {
                        if (activo.status.Equals("AGREGAR"))
                        {
                            sql =
                                "INSERT INTO activos_responsivasdetalle(idresponsiva, idactivo, status) " +
                                "VALUES (@idResp, @idActivo, 'A')";
                        }

                        if (activo.status.Equals("ELIMINAR"))
                        {
                            sql =
                                "UPDATE activos_responsivasdetalle SET status = 'B' " +
                                "WHERE idresponsiva = @idResp and idactivo = @idActivo and status = 'A'";
                        }

                        // define parametros
                        cmd.Parameters.AddWithValue("@idResp", idResponsiva);
                        cmd.Parameters.AddWithValue("@idActivo", activo.idActivo);

                        ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                        if (res.ok)
                        {
                            if (rows == 0) result = false;
                        }
                        else
                        {
                            error = res.numErr + ": " + res.descErr;
                            trans.Rollback();
                            break;
                        }

                        cmd.Parameters.Clear();
                    }

                    trans.Commit();
                }
            }

            return result;
        }

        // busca las resposivas de un usuario
        public List<Responsivas> buscaResponsiva(int idUsuario)
        {
            List<Responsivas> result = new List<Responsivas>();
            Responsivas ent;

            string sql =
                        "select r.idresponsiva, r.idusuario, r.fecha, r.idusuariocrea, r.observaciones, r.fechabaja, r.status " +
                        "from activos_responsivas r " +
                        "left join activos_usuarios u on (r.idusuario = u.idusuario) " +
                        "where u.idusuario = @idUs";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idUs", idUsuario);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Responsivas();

                            ent.idResponsiva = Convert.ToInt16(res.reader["idresponsiva"]);
                            ent.idUsuario = Convert.ToInt16(res.reader["idusuario"]);
                            ent.idUsuarioCrea = Convert.ToInt16(res.reader["idusuariocrea"]);

                            DateTime dt = DateTime.Parse(Convert.ToString(res.reader["fecha"]));
                            ent.fecha = dt.ToString("dd/MM/yyyy");

                            ent.observaciones = Convert.ToString(res.reader["observaciones"]);
                            ent.fechaBaja = Convert.ToString(res.reader["fechabaja"]);
                            ent.status = Convert.ToString(res.reader["status"]);

                            result.Add(ent);
                        }
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }
    }
}
