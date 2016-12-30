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


        public bool actNumEtiquetaActivo(long idActivo, string numEtiqueta)
        {
            string sql = "UPDATE activos_activos SET numetiqueta = @numEti where idactivo = @idActivo";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

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
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);
                }
            }

            return result;
        }
    }
}
