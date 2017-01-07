using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Activos.Datos
{
    public class ActivosDatos : IActivosDatos
    {
        
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexion;

        public ActivosDatos()
        {
            // Establece la cadena de conexión
            _conexion = new Conexion(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        }

        // guarda un activo
        public long guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario, string claveActivo)
        {
            string sql = 
                "INSERT INTO activos_activos(nombrecorto, descripcion, idarea, idtipo, idusuarioalta, claveactivo, status) " + 
                "VALUES (@nombre, @descrip, @idArea, @idTipo, @idUs, @cveAct, 'A')";

            long result = 0;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descrip", descripcion);
                    cmd.Parameters.AddWithValue("@idArea", idArea);
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);
                    cmd.Parameters.AddWithValue("@idUs", idUsuario);
                    cmd.Parameters.AddWithValue("@cveAct", claveActivo);

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

        // obtiene un consecutivo por tipo
        public string obtConsecTipo(int idTipo)
        {
            string result = string.Empty;

            string sql =
                "select CONVERT(SUBSTRING(claveactivo, 3), SIGNED INTEGER) entero " +
                "from activos_activos where idtipo = @idTipo order by 1 desc limit 1";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                result = (Convert.ToInt16(res.reader[0]) + 1).ToString();
                            }
                        else result = "1";
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result.PadLeft(4, '0');
        }

        // actualiza el numero de etiqueta de activos
        public bool actNumEtiquetaActivo(long idActivo, string numEtiqueta)
        {
            string sql = "UPDATE activos_activos SET numetiqueta = @numEti where idactivo = @idActivo";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();
                string error = string.Empty;

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idActivo", idActivo);
                    cmd.Parameters.AddWithValue("@numEti", numEtiqueta);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else error = res.numErr + ": " + res.descErr;
                }

                if (!string.IsNullOrEmpty(error))
                {
                    using (var cmd = new MySqlCommand())
                    {
                        string sqlA = string.Format("delete from activos_activos where idactivo = {0}", idActivo);
                        cmd.Connection = conn;

                        int rows2 = 0;

                        Utilerias.EjecutaSQL(sqlA, ref rows2, cmd);
                    }

                    throw new Exception(error);
                }
            }

            return result;
        }

        // busqueda de activos por tipo y nombre
        public List<Modelos.Activos> getBuscaActivos(int idTipo, string nombre, string status)
        {
            List<Modelos.Activos> result = new List<Modelos.Activos>();
            Modelos.Activos ent;

            string sql =
                "select a.idactivo, a.idarea, ar.nombre as area, a.idtipo, t.nombre as tipo, " +
                        "a.nombrecorto, a.descripcion, a.fechaalta, a.numetiqueta, a.claveactivo, " +
                        "a.idusuarioalta, a.fechamodificacion, a.idusuariomodifica, a.costo, a.status " +
                "from activos_activos a " +
                "left join activos_responsivasdetalle rd on (a.idactivo = rd.idactivo) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_tipo t on (a.idtipo = t.idtipo) " +
                "where a.status = @status and rd.idactivo is null and a.idtipo = @idTipo and a.nombrecorto like @nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);
                    cmd.Parameters.AddWithValue("@status", status);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.Activos();

                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);

                                ent.idArea = Convert.ToInt16(res.reader["idarea"]);
                                ent.area = Convert.ToString(res.reader["area"]);

                                ent.idTipo = Convert.ToInt16(res.reader["idtipo"]);
                                ent.tipo = Convert.ToString(res.reader["tipo"]);

                                ent.nombreCorto = Convert.ToString(res.reader["nombrecorto"]);
                                ent.descripcion = Convert.ToString(res.reader["descripcion"]).Replace("&", "---").Trim();
                                ent.fechaAlta = Convert.ToString(res.reader["fechaalta"]);
                                ent.numEtiqueta = Convert.ToString(res.reader["numetiqueta"]);
                                ent.claveActivo= Convert.ToString(res.reader["claveactivo"]);

                                ent.idUsuarioAlta = Convert.ToInt16(res.reader["idusuarioalta"]);

                                if (res.reader["idusuariomodifica"] is DBNull) ent.idUsuarioModifica = null;
                                else ent.idUsuarioModifica = Convert.ToInt16(res.reader["idusuariomodifica"]);

                                if (res.reader["fechamodificacion"] is DBNull) ent.fechaModificacion = string.Empty;
                                else ent.fechaModificacion = Convert.ToString(res.reader["fechamodificacion"]);

                                if (res.reader["costo"] is DBNull) ent.costo = null;
                                else ent.costo = Convert.ToDecimal(res.reader["costo"]);

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

        // busca los activos que contengan cierto numero de etiqueta o por clave de articulo
        public List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq)
        {
            List<Modelos.Activos> result = new List<Modelos.Activos>();
            Modelos.Activos ent;

            string sql =
                "select a.idactivo, a.idarea, ar.nombre as area, a.idtipo, t.nombre as tipo, " +
                        "a.nombrecorto, a.descripcion, a.fechaalta, a.numetiqueta, a.claveactivo, " +
                        "a.idusuarioalta, a.fechamodificacion, a.idusuariomodifica, a.costo, a.status " +
                "from activos_activos a " +
                "left join activos_responsivasdetalle rd on (a.idactivo = rd.idactivo) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_tipo t on (a.idtipo = t.idtipo) " +
                "where a.status = 'A' and rd.idactivo is null";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    if (tipoBq.Equals("NE"))
                    {
                        sql += " and a.numetiqueta like @numEti";
                        cmd.Parameters.AddWithValue("@numEti", parametro + "%");
                    }

                    if (tipoBq.Equals("CA"))
                    {
                        sql += " and a.claveactivo like @cveArt";
                        cmd.Parameters.AddWithValue("@cveArt", parametro + "%");
                    }


                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.Activos();

                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);

                                ent.idArea = Convert.ToInt16(res.reader["idarea"]);
                                ent.area = Convert.ToString(res.reader["area"]);

                                ent.idTipo = Convert.ToInt16(res.reader["idtipo"]);
                                ent.tipo = Convert.ToString(res.reader["tipo"]);

                                ent.nombreCorto = Convert.ToString(res.reader["nombrecorto"]);
                                ent.descripcion = Convert.ToString(res.reader["descripcion"]).Replace("&", "---").Trim();
                                ent.fechaAlta = Convert.ToString(res.reader["fechaalta"]);
                                ent.numEtiqueta = Convert.ToString(res.reader["numetiqueta"]);
                                ent.claveActivo = Convert.ToString(res.reader["claveactivo"]);

                                ent.idUsuarioAlta = Convert.ToInt16(res.reader["idusuarioalta"]);

                                if (res.reader["idusuariomodifica"] is DBNull) ent.idUsuarioModifica = null;
                                else ent.idUsuarioModifica = Convert.ToInt16(res.reader["idusuariomodifica"]);

                                if (res.reader["fechamodificacion"] is DBNull) ent.fechaModificacion = string.Empty;
                                else ent.fechaModificacion = Convert.ToString(res.reader["fechamodificacion"]);

                                if (res.reader["costo"] is DBNull) ent.costo = null;
                                else ent.costo = Convert.ToDecimal(res.reader["costo"]);

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

        // busca activos por tipo y nombre
        public List<ActivosDesc> getBuscaActivosResp(int idTipo, string nombre, string status)
        {
            List<Modelos.ActivosDesc> result = new List<Modelos.ActivosDesc>();
            Modelos.ActivosDesc ent;

            string sql =
                "select a.idactivo, r.idusuario, u.nombre as usuario, a.idarea, ar.nombre as area, " +
                        "s.idsucursal, s.nombre as sucursal, a.idtipo, t.nombre as tipo, " +
                        "a.nombrecorto, a.descripcion, a.fechaalta, a.numetiqueta, a.claveactivo, " +
                        "a.idusuarioalta, a.fechamodificacion, a.idusuariomodifica, a.costo, a.status " +
                "from activos_activos a " +
                "left join activos_responsivasdetalle rd on (a.idactivo = rd.idactivo) " +
                "left join activos_responsivas r on (r.idresponsiva = rd.idresponsiva) " +
                "left join activos_usuarios u on (r.idusuario = u.idusuario) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_sucursales s on (ar.idsucursal = s.idsucursal) " +
                "left join activos_tipo t on (a.idtipo = t.idtipo) " +
                "where a.status = @status and a.idtipo = @idTipo and a.nombrecorto like @nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);
                    cmd.Parameters.AddWithValue("@status", status);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.ActivosDesc();

                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);

                                ent.area = Convert.ToString(res.reader["area"]);

                                ent.tipo = Convert.ToString(res.reader["tipo"]);
                                ent.idTipo = Convert.ToInt16(res.reader["idtipo"]);

                                ent.sucursal = Convert.ToString(res.reader["sucursal"]);

                                ent.usuario = Convert.ToString(res.reader["usuario"]);

                                ent.nombreCorto = Convert.ToString(res.reader["nombrecorto"]);
                                ent.descripcion = Convert.ToString(res.reader["descripcion"]);

                                ent.numEtiqueta = Convert.ToString(res.reader["numetiqueta"]);
                                ent.claveActivo = Convert.ToString(res.reader["claveactivo"]);

                                if (res.reader["costo"] is DBNull) ent.costo = null;
                                else ent.costo = Convert.ToDecimal(res.reader["costo"]);

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

        // busca un activo segun un tipo de busqueda
        public List<ActivosDesc> getBuscaActivosResp(string parametro, string tipoBq)
        {
            List<Modelos.ActivosDesc> result = new List<Modelos.ActivosDesc>();
            Modelos.ActivosDesc ent;

            string sql =
                "select a.idactivo, r.idusuario, u.nombre as usuario, a.idarea, ar.nombre as area, " +
                        "s.idsucursal, s.nombre as sucursal, a.idtipo, t.nombre as tipo, " +
                        "a.nombrecorto, a.descripcion, a.fechaalta, a.numetiqueta, a.claveactivo, " +
                        "a.idusuarioalta, a.fechamodificacion, a.idusuariomodifica, a.costo, a.status " +
                "from activos_activos a " +
                "left join activos_responsivasdetalle rd on (a.idactivo = rd.idactivo) " +
                "left join activos_responsivas r on (r.idresponsiva = rd.idresponsiva) " +
                "left join activos_usuarios u on (r.idusuario = u.idusuario) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_sucursales s on (ar.idsucursal = s.idsucursal) " +
                "left join activos_tipo t on (a.idtipo = t.idtipo) " +
                "where a.status = 'A'";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    if (tipoBq.Equals("NE"))
                    {
                        sql += " and a.numetiqueta like @numEti";
                        cmd.Parameters.AddWithValue("@numEti", parametro + "%");
                    }

                    if (tipoBq.Equals("CA"))
                    {
                        sql += " and a.claveactivo like @cveArt";
                        cmd.Parameters.AddWithValue("@cveArt", parametro + "%");
                    }


                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.ActivosDesc();

                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);

                                ent.area = Convert.ToString(res.reader["area"]);

                                ent.tipo = Convert.ToString(res.reader["tipo"]);
                                ent.idTipo = Convert.ToInt16(res.reader["idtipo"]);

                                ent.sucursal = Convert.ToString(res.reader["sucursal"]);

                                ent.usuario = Convert.ToString(res.reader["usuario"]);

                                ent.nombreCorto = Convert.ToString(res.reader["nombrecorto"]);
                                ent.descripcion = Convert.ToString(res.reader["descripcion"]);

                                ent.numEtiqueta = Convert.ToString(res.reader["numetiqueta"]);
                                ent.claveActivo = Convert.ToString(res.reader["claveactivo"]);

                                if (res.reader["costo"] is DBNull) ent.costo = null;
                                else ent.costo = Convert.ToDecimal(res.reader["costo"]);

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

        // realiza busqueda por usuario 
        public List<ActivosDesc> busquedaUsuariosResponsiva(string usuario, string busqueda)
        {
            List<Modelos.ActivosDesc> result = new List<Modelos.ActivosDesc>();
            Modelos.ActivosDesc ent;

            string sql = string.Format(
                "select a.idactivo, r.idusuario, u.nombre as usuario, a.idarea, ar.nombre as area, " +
                        "s.idsucursal, s.nombre as sucursal, a.idtipo, t.nombre as tipo, " +
                        "a.nombrecorto, a.descripcion, a.fechaalta, a.numetiqueta, a.claveactivo, " +
                        "a.idusuarioalta, a.fechamodificacion, a.idusuariomodifica, a.costo, a.status " +
                "from activos_activos a " +
                "left join activos_responsivasdetalle rd on (a.idactivo = rd.idactivo) " +
                "left join activos_responsivas r on (r.idresponsiva = rd.idresponsiva) " +
                "left join activos_usuarios u on (r.idusuario = u.idusuario) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_sucursales s on (ar.idsucursal = s.idsucursal) " +
                "left join activos_tipo t on (a.idtipo = t.idtipo) " +
                "where a.status = 'A' and u.{0} LIKE @usuario order by u.{0}", busqueda);

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@usuario", "%" + usuario + "%");

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.ActivosDesc();

                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);

                                ent.area = Convert.ToString(res.reader["area"]);

                                ent.tipo = Convert.ToString(res.reader["tipo"]);
                                ent.idTipo = Convert.ToInt16(res.reader["idtipo"]);

                                ent.sucursal = Convert.ToString(res.reader["sucursal"]);

                                ent.usuario = Convert.ToString(res.reader["usuario"]);

                                ent.nombreCorto = Convert.ToString(res.reader["nombrecorto"]);
                                ent.descripcion = Convert.ToString(res.reader["descripcion"]);

                                ent.numEtiqueta = Convert.ToString(res.reader["numetiqueta"]);
                                ent.claveActivo = Convert.ToString(res.reader["claveactivo"]);

                                if (res.reader["costo"] is DBNull) ent.costo = null;
                                else ent.costo = Convert.ToDecimal(res.reader["costo"]);

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

        // modifica un activo
        public bool modificActivo(int? idActivo, string nombre, string descripcion)
        {
            string sql =
                "UPDATE activos_activos SET nombrecorto = @nombre, descripcion = @desc, idusuariomodifica = @idUsModif " +
                "where idactivo = @idActivo";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@desc", descripcion);
                    cmd.Parameters.AddWithValue("@idActivo", idActivo);
                    cmd.Parameters.AddWithValue("@idUsModif", Login.idUsuario);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);
                }
            }

            return result;
        }

        // crea un registro de baja o de reparacion
        public long bajaActivo(int? idActivo, string motivo, string causa, string fecha, int idUsuario)
        {
            long result = 0;

            string sql = string.Empty;

            if (motivo.Equals("R"))
            {
                sql = "INSERT INTO activos_reparacion (idactivo, idusuarioresponsable, fechainicio, causa, status) " +
                      "VALUES(@idActivo, @idUs, @fecha, @causa, 'A')";
            }

            if (motivo.Equals("B"))
            {
                sql = "INSERT INTO activos_baja (idactivo, idusuariobaja, fecha, motivo) " +
                      "VALUES(@idActivo, @idUs, @fecha, @causa)";
            }

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idActivo", idActivo);
                    cmd.Parameters.AddWithValue("@idUs", idUsuario);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@causa", causa);

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

        // actualiza estatus en tablas relacionadas al activo
        public bool actualizaStatus(long idRB, int? idActivo, string motivo)
        {
            int idRD = 0;

            long sqlAL = 0;
            long sqlRL = 0;

            int rows = 0;

            bool result = true;

            try
            {
                string sqlA = string.Format(
                    "UPDATE activos_activos SET status = '{0}' " +
                    "WHERE idactivo = {1}", motivo, idActivo);

                using (var conn = this._conexion.getConexion())
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;

                        // actualiza ACTIVOS
                        ManejoSql res = Utilerias.EjecutaSQL(sqlA, ref rows, cmd);

                        if (res.ok)
                        {
                            if (rows == 0) sqlAL = 0;
                            else sqlAL = cmd.LastInsertedId;
                        }
                        else
                            throw new Exception(res.numErr + ": " + res.descErr);

                        // actualiza RESPONISVA_DETALLE
                        string sqlRDS = string.Format("select idresposivadet from activos_responsivasdetalle where idactivo = {0} and status = 'A'", idActivo);
                        res = Utilerias.EjecutaSQL(sqlA, cmd);

                        if (res.ok)
                        {
                            if (res.reader.HasRows)
                                while (res.reader.Read())
                                {
                                    idRD = (int)res.reader["idresponsivadet"];
                                }
                        }
                        else
                            throw new Exception(res.numErr + ": " + res.descErr);

                        res.reader.Close();

                        rows = 0;

                        res = Utilerias.EjecutaSQL(string.Format("update activos_responsivasdetalle set status = '{0}' where idresposivadet = {1}", motivo, idRD), ref rows, cmd);

                        if (res.ok)
                        {
                            if (rows == 0) sqlRL = 0;
                            else sqlRL = cmd.LastInsertedId;
                        }
                        else
                            throw new Exception(res.numErr + ": " + res.descErr);

                    }

                }
            }
            catch (Exception e)
            {
                // deshacer modificaciones

                using (var conn = this._conexion.getConexion())
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;

                        string sql = string.Empty;

                        int rowsAf = 0;

                        var a = Utilerias.EjecutaSQL(string.Format(
                            "delete from {0} where {1} = {2}", 
                                    motivo.Equals("B")?"activos_baja":"activos_reparacion",
                                    motivo.Equals("B")?"idbaja":"idreparacion",
                                    idRB
                            ),
                            ref rowsAf, cmd);


                         var b = Utilerias.EjecutaSQL(string.Format(
                            "update activos_activos set status = 'A' where idactivo = {0}",
                                    idActivo
                            ),
                            ref rowsAf, cmd);


                        var c = Utilerias.EjecutaSQL(string.Format(
                            "update activos_resposivasdetalle set status = 'A' where idresponsivadet = {0}",
                                    idActivo
                            ),
                            ref rowsAf, cmd);
                    }

                }

                throw new Exception(e.Message);
            }

            return result;
        }
    }
}
