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
    }
}
