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
            _conexion = new Conexion(Modelos.ConectionString.conn);
        }

        // crea responsivas
        public long crearResponsivas(int idUsuarioCreador, int? idUsuario, string observaciones)
        {
            long result = 0;

            string sql =
                "INSERT INTO activos_responsivas(idpersona, idusuariocrea, observaciones, fecha, status) " +
                "VALUES (@idUs, @idUsCrea, @observ, now(), 'A')";

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
        public bool creaRespDet(long idResp, List<Modelos.Activos> activos, List<Modelos.PersonaResponsivas> responsables)
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

                        cmd.Parameters.Clear();
                    }
                }

                sql = 
                    "insert into activos_resposivaresponsables (idpersona, idresponsiva)" + 
                    "values (@idpersona, @idResp)";

                foreach (Modelos.PersonaResponsivas pr in responsables)
                {
                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;

                        // define parametros
                        cmd.Parameters.AddWithValue("@idResp", idResp);
                        cmd.Parameters.AddWithValue("@idpersona", pr.idPersona);

                        ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                        if (!res.ok)
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
                        string sqlR2 = string.Format("delete from activos_resposivaresponsables where idresponsiva = {0}", idResp);
                        cmd.Connection = conn;

                        int rows2 = 0;

                        Utilerias.EjecutaSQL(sqlD, ref rows2, cmd);

                        Utilerias.EjecutaSQL(sqlR, ref rows2, cmd);

                        Utilerias.EjecutaSQL(sqlR2, ref rows2, cmd);

                    }

                    throw new Exception(error);
                }
            }

            return result;
        }

        // consulta las responsivas por sucursal y nombre
        public List<Responsivas> buscaResponsiva(string responsable, int idSuc, string tipoCons)
        {
            List<Responsivas> result = new List<Responsivas>();
            Responsivas ent;

            string sql =
                        "select r.idresponsiva, r.idpersona, r.fecha, r.idusuariocrea, r.observaciones, r.fechabaja, r.status, " +
                        "p.nombrecompleto, " +
                        "pu.nombre as puesto, " +
                        "s.nombre as sucursal " +
                        "from activos_responsivas r " +
                        "left join activos_personas p on (r.idpersona = p.idpersona) " +
                        "left join activos_usuarios u on (p.idpersona = u.idpersona) " +
                        "left join activos_puesto pu on (p.idpuesto = pu.idpuesto) " +
                        "left join activos_sucursales s on (pu.idsucursal = s.idsucursal) " +
                        "left join activos_responsivasdetalle rd on (r.idresponsiva = rd.idresponsiva) " +
                        "where s.idsucursal = @isSucursal and p.nombrecompleto LIKE @nomb and rd.status != @status and r.status != 'B' " +
                        "group by r.idresponsiva, r.idpersona, r.fecha, r.idusuariocrea, r.observaciones, r.fechabaja, r.status, " +
                        "p.nombrecompleto, pu.nombre, s.nombre order by p.nombrecompleto ";
            
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
                    cmd.Parameters.AddWithValue("@status", tipoCons);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Responsivas();

                            ent.idResponsiva = Convert.ToInt16(res.reader["idresponsiva"]);
                            ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);
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
        public bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos, List<int> idsResp)
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

                    string sqlN = "delete from activos_resposivaresponsables where idresponsiva = @idresp";

                        // define parametros
                    cmd.Parameters.AddWithValue("@idresp", idResponsiva);

                    ManejoSql res1 = Utilerias.EjecutaSQL(sqlN, ref rows, cmd);

                    if (!res1.ok)
                    {
                        error = res1.numErr + ": " + res1.descErr;
                        trans.Rollback();
                    }

                    cmd.Parameters.Clear();

                    // resonsables
                    foreach (int id in idsResp)
                    {
                        string sql2 = 
                            "insert into activos_resposivaresponsables (idpersona, idresponsiva)" +
                            "values (@idpersona, @idResp)";

                        // define parametros
                        cmd.Parameters.AddWithValue("@idpersona", id);
                        cmd.Parameters.AddWithValue("@idResp", idResponsiva);

                        ManejoSql res = Utilerias.EjecutaSQL(sql2, ref rows, cmd);

                        if (res.ok)
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
                        "select r.idresponsiva, r.idpersona, r.fecha, r.idusuariocrea, r.observaciones, r.fechabaja, r.status " +
                        "from activos_responsivas r " +
                        "left join activos_personas u on (r.idpersona = u.idpersona) " +
                        "where u.idpersona = @idUs and r.status != 'B'";

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
                            ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);
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

        // agrega a una responsiva existente los activos a traspasar
        // y quita activos a la responsiva anterior
        public bool traspasoRespExist(List<Modelos.Activos> activosAnterior, int? idUsuarioN, int? idUsuarioA, string motivo, 
            List<Modelos.Activos> activosTraspaso, int? idRespTraspaso, int? idResponsiva)
        {
            MySqlTransaction trans;

            bool result = true;

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

                    string ids = string.Join(",", activosTraspaso.Select(s => s.idActivo).ToList());

                    // quitar activos de responsiva anterior
                    string sqlQuitaActivos = 
                        "update activos_responsivasdetalle set status = 'B' " +
                        "where idresponsiva = @idResp and FIND_IN_SET(idactivo, @parameter) != 0 and status = 'A'";

                    // define parametros
                    cmd.Parameters.AddWithValue("@idResp", idResponsiva);
                    cmd.Parameters.AddWithValue("@parameter", ids);

                    ManejoSql res = Utilerias.EjecutaSQL(sqlQuitaActivos, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    // agrega los activos a la responsiva existente
                    string sqlInsertaActivos =
                        "insert into activos_responsivasdetalle (idactivo, idresponsiva, status) " +
                        "values (@idActivo, @idRespon, 'A')";

                    foreach (Modelos.Activos act in activosTraspaso)
                    {
                        cmd.Parameters.Clear();

                        // define parametros
                        cmd.Parameters.AddWithValue("@idRespon", idRespTraspaso);
                        cmd.Parameters.AddWithValue("@idActivo", act.idActivo);

                        ManejoSql res1 = Utilerias.EjecutaSQL(sqlInsertaActivos, ref rows, cmd);

                        if (res1.ok)
                        {
                            if (rows == 0) result = false;
                        }
                        else
                        {
                            trans.Rollback();
                            throw new Exception(res1.numErr + ": " + res1.descErr);
                        }
                    }

                    // actualiza los activos
                    string sqlUpdateActivos =
                        "update activos_activos set idarea = @idArea " +
                        "where idactivo = @idActivo";

                    foreach (Modelos.Activos act in activosTraspaso)
                    {
                        cmd.Parameters.Clear();

                        // define parametros
                        cmd.Parameters.AddWithValue("@idArea", act.idArea);
                        cmd.Parameters.AddWithValue("@idActivo", act.idActivo);

                        ManejoSql res1 = Utilerias.EjecutaSQL(sqlUpdateActivos, ref rows, cmd);

                        if (res1.ok)
                        {
                            if (rows == 0) result = false;
                        }
                        else
                        {
                            trans.Rollback();
                            throw new Exception(res1.numErr + ": " + res1.descErr);
                        }
                    }

                    // D E F I N E   E L   H I S T O R I A L   D E   C A M B I O
                    string sqlHC = 
                        "insert into activos_cambio (idpersonaant, idareaanterior, idpersonanuevo, idareanueva, fecha, motivo, idactivo) " +
                        "values (@idpera, @idareaa, @idpern, @idarean, now(), @motivo, @idactivo)";

                    foreach (Modelos.Activos act in activosTraspaso)
                    {
                        cmd.Parameters.Clear();

                        Modelos.Activos activoAnt = activosAnterior.Where(w => w.idActivo == act.idActivo).FirstOrDefault();

                        // define parametros
                        cmd.Parameters.AddWithValue("@idpera", idUsuarioA);
                        cmd.Parameters.AddWithValue("@idareaa", activoAnt.idArea);
                        cmd.Parameters.AddWithValue("@idpern", idUsuarioN);
                        cmd.Parameters.AddWithValue("@idarean", act.idArea);
                        cmd.Parameters.AddWithValue("@motivo", motivo);
                        cmd.Parameters.AddWithValue("@idactivo", act.idActivo);

                        ManejoSql res1 = Utilerias.EjecutaSQL(sqlHC, ref rows, cmd);

                        if (!res1.ok)
                        {
                            trans.Rollback();
                            throw new Exception(res1.numErr + ": " + res1.descErr);
                        }
                    }


                    trans.Commit();
                }
            }

            return result;
        }

        // crea una responsiva y le asocia los activos nuevos
        // y quita activos a la responsiva anterior
        public bool traspasoCreaResp(List<Modelos.Activos> activosAnterior, int? idUsuarioA, string motivo, 
            List<Modelos.Activos> activosTraspaso, int? idResponsiva, string observaciones, int? idUsuario, int idUsCrea)
        {
            MySqlTransaction trans;

            bool result = true;

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

                    // activos a cambiar
                    string ids = string.Join(",", activosTraspaso.Select(s => s.idActivo).ToList());

                    // quitar activos de responsiva anterior
                    string sqlQuitaActivos =
                        "update activos_responsivasdetalle set status = 'B' " +
                        "where idresponsiva = @idResp and FIND_IN_SET(idactivo, @parameter) != 0 and status = 'A'";

                    // define parametros
                    cmd.Parameters.AddWithValue("@idResp", idResponsiva);
                    cmd.Parameters.AddWithValue("@parameter", ids);

                    ManejoSql res = Utilerias.EjecutaSQL(sqlQuitaActivos, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    // crear la responsiva
                    long idResp = 0;

                    string sqlCreaResponsiva =
                        "insert into activos_responsivas (idpersona, idusuariocrea, observaciones, status, fecha) " +
                        "values (@idusuario, @idUsCrea, @observ, 'A', now())";

                    // define parametros
                    cmd.Parameters.AddWithValue("@idusuario", idUsuario);
                    cmd.Parameters.AddWithValue("@idUsCrea", idUsCrea);
                    cmd.Parameters.AddWithValue("@observ", observaciones);

                    res = Utilerias.EjecutaSQL(sqlCreaResponsiva, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                        else idResp = cmd.LastInsertedId;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }


                    // agrega los activos a la responsiva creada
                    string sqlInsertaActivos =
                        "insert into activos_responsivasdetalle (idactivo, idresponsiva, status) " +
                        "values (@idActivo, @idRespon, 'A')";

                    foreach (Modelos.Activos act in activosTraspaso)
                    {
                        cmd.Parameters.Clear();

                        // define parametros
                        cmd.Parameters.AddWithValue("@idRespon", idResp);
                        cmd.Parameters.AddWithValue("@idActivo", act.idActivo);

                        ManejoSql res1 = Utilerias.EjecutaSQL(sqlInsertaActivos, ref rows, cmd);

                        if (res1.ok)
                        {
                            if (rows == 0) result = false;
                        }
                        else
                        {
                            trans.Rollback();
                            throw new Exception(res1.numErr + ": " + res1.descErr);
                        }
                    }

                    // actualiza los activos
                    string sqlUpdateActivos =
                        "update activos_activos set idarea = @idArea " +
                        "where idactivo = @idActivo";

                    foreach (Modelos.Activos act in activosTraspaso)
                    {
                        cmd.Parameters.Clear();

                        // define parametros
                        cmd.Parameters.AddWithValue("@idArea", act.idArea);
                        cmd.Parameters.AddWithValue("@idActivo", act.idActivo);

                        ManejoSql res1 = Utilerias.EjecutaSQL(sqlUpdateActivos, ref rows, cmd);

                        if (res1.ok)
                        {
                            if (rows == 0) result = false;
                        }
                        else
                        {
                            trans.Rollback();
                            throw new Exception(res1.numErr + ": " + res1.descErr);
                        }
                    }


                    // D E F I N E   E L   H I S T O R I A L   D E   C A M B I O
                    string sqlHC =
                        "insert into activos_cambio (idpersonaant, idareaanterior, idpersonanuevo, idareanueva, fecha, motivo, idactivo) " +
                        "values (@idpera, @idareaa, @idpern, @idarean, now(), @motivo, @idactivo)";

                    foreach (Modelos.Activos act in activosTraspaso)
                    {
                        cmd.Parameters.Clear();

                        Modelos.Activos activoAnt = activosAnterior.Where(w => w.idActivo == act.idActivo).FirstOrDefault();

                        // define parametros
                        cmd.Parameters.AddWithValue("@idpera", idUsuarioA);
                        cmd.Parameters.AddWithValue("@idareaa", activoAnt.idArea);
                        cmd.Parameters.AddWithValue("@idpern", idUsuario);
                        cmd.Parameters.AddWithValue("@idarean", act.idArea);
                        cmd.Parameters.AddWithValue("@motivo", motivo);
                        cmd.Parameters.AddWithValue("@idactivo", act.idActivo);

                        ManejoSql res1 = Utilerias.EjecutaSQL(sqlHC, ref rows, cmd);

                        if (!res1.ok)
                        {
                            trans.Rollback();
                            throw new Exception(res1.numErr + ": " + res1.descErr);
                        }
                    }

                    trans.Commit();
                }
            }

            return result;
        }

        // baja a la responsiva seleccionada
        public bool bajaResponsiva(int? idResponsiva, string motivo)
        {
            MySqlTransaction trans;

            bool result = true;

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

                    string sqlRD =
                        "UPDATE activos_responsivasdetalle SET status = 'B' " +
                        "WHERE idresponsiva = @idResp";

                    // define parametros
                    cmd.Parameters.AddWithValue("@idResp", idResponsiva);

                    ManejoSql res = Utilerias.EjecutaSQL(sqlRD, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = true;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    string sqlR =
                        "UPDATE activos_responsivas SET status = 'B', motivobaja = @motivo, fechabaja = NOW() " +
                        "WHERE idresponsiva = @idResp";

                    // define parametros
                    cmd.Parameters.AddWithValue("@motivo", motivo);
                    cmd.Parameters.AddWithValue("@idResp", idResponsiva);

                    res = Utilerias.EjecutaSQL(sqlR, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }
                   
                    trans.Commit();
                }
            }

            return result;
        }

        // obtiene el comando de una etiqueta
        public string getBuscaComandoEt(string etiqueta)
        {
            string result = string.Empty;

            string sql = "select comando from activos_comandosetiquetas where etiqueta = @etiqueta";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@etiqueta", etiqueta);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            result = Convert.ToString(res.reader["comando"]);
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

        // obtiene los responsables segun una responsiva
        public List<PersonaResponsivas> obtieneResponsables(int idResponsiva)
        {
            List<PersonaResponsivas> result = new List<PersonaResponsivas>();
            PersonaResponsivas ent;

            string sql =
                        "select r.idpersona, p.nombrecompleto as nombre, pu.nombre as puesto, " +
                        "s.nombre as sucursal from activos_resposivaresponsables r " +
                        "left join activos_personas p on (r.idpersona = p.idpersona) " +
                        "left join activos_puesto pu on (p.idpuesto = pu.idpuesto) " +
                        "left join activos_sucursales s on (pu.idsucursal = s.idsucursal) " +
                        "where r.idresponsiva = @idresp";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idresp", idResponsiva);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new PersonaResponsivas();

                            ent.nombre = Convert.ToString(res.reader["nombre"]);
                            ent.nombre = ent.nombre.Replace("&", " ");
                            ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);

                            ent.sucursal = Convert.ToString(res.reader["nombre"]);
                            ent.puesto = Convert.ToString(res.reader["puesto"]);

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


        public List<PersonaResponsivas> buscaResponsiva(string responsable, int idSuc)
        {
            List<PersonaResponsivas> result = new List<PersonaResponsivas>();
            PersonaResponsivas ent;

            string sql =
                        "select r.idpersona, p.nombrecompleto as nombre, pu.nombre as puesto, " +
                                "s.nombre as sucursal , s.idsucursal " +
                        "from activos_responsivas r " +
                        "left join activos_personas p on (r.idpersona = p.idpersona) " +
                        "left join activos_puesto pu on (p.idpuesto = pu.idpuesto) " +
                        "left join activos_sucursales s on (pu.idsucursal = s.idsucursal) " +
                        "where p.nombrecompleto like @resp and s.idsucursal = @idsucu " +
                        "group by r.idpersona, p.nombrecompleto, pu.nombre, s.nombre, s.idsucursal ";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@resp", "%" + responsable + "%");
                    cmd.Parameters.AddWithValue("@idsucu", idSuc);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new PersonaResponsivas();

                            ent.nombre = Convert.ToString(res.reader["nombre"]);
                            ent.nombre = ent.nombre.Replace("&", " ");
                            ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);

                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);
                            ent.puesto = Convert.ToString(res.reader["puesto"]);

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
