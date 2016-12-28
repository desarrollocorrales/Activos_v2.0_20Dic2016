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

        public bool guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario)
        {
            string sql = 
                "INSERT INTO activos_activos(nombrecorto, descripcion, idarea, idtipo, idusuarioalta, status) " + 
                "VALUES (@nombre, @descrip, @idArea, @idTipo, @idUs, 'A')";

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
                    cmd.Parameters.AddWithValue("@descrip", descripcion);
                    cmd.Parameters.AddWithValue("@idArea", idArea);
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);
                    cmd.Parameters.AddWithValue("@idUs", idUsuario);

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
