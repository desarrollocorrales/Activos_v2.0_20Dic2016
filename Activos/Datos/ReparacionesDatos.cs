using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Activos.Datos
{
    public class ReparacionesDatos : IReparacionesDatos
    {
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexion;

        public ReparacionesDatos()
        {
            // Establece la cadena de conexión
            _conexion = new Conexion(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        }


        // obtiene las reparaciones de los activos enviados
        public List<Reparaciones> getActivosEnRepar(List<int> activosIds)
        {

            List<Modelos.Reparaciones> result = new List<Modelos.Reparaciones>();
            Modelos.Reparaciones ent;

            string sql =
                "select r.idreparacion, r.idactivo, r.idusuarioresponsable, r.fechainicio, r.observacionesactivacion, " +
                        "r.fechafin, r.causa, r.status, a.nombrecorto as activo, a.idtipo, p.nombrecompleto as usuario " +
                "from activos_reparacion r " +
                "left join activos_activos a on (r.idactivo = a.idactivo) " +
                "left join activos_usuarios u on (r.idusuarioresponsable = u.idusuario) " +
                "left join activos_personas p on (u.idpersona = p.idpersona) " +
                "where FIND_IN_SET(r.idactivo, @parameter) != 0 and r.status = 'A' order by a.nombrecorto";

            string wherIn = string.Join(",", activosIds);

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.Reparaciones();

                                ent.idReparacion = Convert.ToInt16(res.reader["idreparacion"]);
                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);
                                ent.idUsuarioResp = Convert.ToInt16(res.reader["idusuarioresponsable"]);

                                ent.usuario = Convert.ToString(res.reader["usuario"]);

                                ent.usuario = ent.usuario.Replace("&", " ");

                                ent.activo = Convert.ToString(res.reader["activo"]);

                                if (res.reader["fechainicio"] is DBNull) ent.fechaInicio = null;
                                else
                                {
                                    DateTime dt = DateTime.Parse(Convert.ToString(res.reader["fechainicio"]));
                                    ent.fechaInicio = dt.ToString("dd/MM/yyyy");
                                }

                                if (res.reader["fechafin"] is DBNull) ent.fechaFin = null;
                                else ent.fechaFin = Convert.ToString(res.reader["fechafin"]);


                                ent.causa = Convert.ToString(res.reader["causa"]);
                                ent.observActivacion = Convert.ToString(res.reader["observacionesactivacion"]);

                                ent.status= Convert.ToString(res.reader["status"]);

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
