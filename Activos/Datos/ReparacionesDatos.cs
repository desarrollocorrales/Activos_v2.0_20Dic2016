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
            _conexion = new Conexion(Modelos.ConectionString.conn);
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

        // obtiene los activos que han sido dados de baja por sucursal
        public List<Bajas> getBajasSuc(int idSuc)
        {
            List<Modelos.Bajas> result = new List<Modelos.Bajas>();
            Modelos.Bajas ent;

            string sql =
                "select ab.idbaja, a.idactivo, a.nombrecorto, ab.fecha, ab.idusuariobaja, pu.nombrecompleto as usuario, " +
                        "ab.observaciones, ab.idmotivobaja, s.idsucursal " +
                "from activos_baja ab " +
                "left join activos_activos a on (ab.idactivo = a.idactivo) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_sucursales s on (ar.idsucursal = s.idsucursal) " +
                "left join activos_usuarios u on (ab.idusuariobaja = u.idusuario) " +
                "left join activos_personas pu on (u.idpersona = pu.idpersona) " +
                "where s.idsucursal = @idsuc ";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idsuc", idSuc);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.Bajas();

                                ent.idBaja = Convert.ToInt16(res.reader["idbaja"]);
                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);
                                ent.activo = Convert.ToString(res.reader["nombrecorto"]);

                                if (res.reader["fecha"] is DBNull) ent.fecha = null;
                                else
                                {
                                    DateTime dt = DateTime.Parse(Convert.ToString(res.reader["fecha"]));
                                    ent.fecha = dt.ToString("dd/MM/yyyy");
                                }

                                ent.idUsuaroBaja = Convert.ToInt16(res.reader["idusuariobaja"]);
                                ent.usuario = Convert.ToString(res.reader["usuario"]);


                                ent.observaciones = Convert.ToString(res.reader["observaciones"]);

                                ent.idMotivoBaja = Convert.ToInt16(res.reader["idmotivobaja"]);

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

        // obtiene los activos que se encuentran en reparacion por sucursal
        public List<Reparaciones> getReparaciones(int idSuc)
        {
            List<Modelos.Reparaciones> result = new List<Modelos.Reparaciones>();
            Modelos.Reparaciones ent;

            string sql =
                "select are.idreparacion, a.idactivo, a.nombrecorto, are.idusuarioresponsable, pu.nombrecompleto, " +
                        "are.fechainicio, are.fechafin, are.causa, are.observacionesactivacion, are.status, s.idsucursal " +
                "from activos_reparacion are " +
                "left join activos_activos a on (are.idactivo = a.idactivo) " +
                "left join activos_areas ar on (a.idarea = ar.idarea) " +
                "left join activos_sucursales s on (ar.idsucursal = s.idsucursal) " +
                "left join activos_usuarios u on (are.idusuarioresponsable = u.idusuario) " +
                "left join activos_personas pu on (u.idpersona = pu.idpersona) " +
                "where s.idsucursal = @idsuc ";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idsuc", idSuc);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                ent = new Modelos.Reparaciones();

                                ent.idReparacion = Convert.ToInt16(res.reader["idreparacion"]);
                                ent.idActivo = Convert.ToInt16(res.reader["idactivo"]);
                                ent.activo = Convert.ToString(res.reader["nombrecorto"]);

                                ent.idUsuarioResp = Convert.ToInt16(res.reader["idusuarioresponsable"]);
                                ent.usuario = Convert.ToString(res.reader["nombrecompleto"]);

                                if (res.reader["fechainicio"] is DBNull) ent.fechaInicio = null;
                                else
                                {
                                    DateTime dt = DateTime.Parse(Convert.ToString(res.reader["fechainicio"]));
                                    ent.fechaInicio = dt.ToString("dd/MM/yyyy");
                                }

                                if (res.reader["fechafin"] is DBNull) ent.fechaFin = null;
                                else
                                {
                                    DateTime dt = DateTime.Parse(Convert.ToString(res.reader["fechafin"]));
                                    ent.fechaFin = dt.ToString("dd/MM/yyyy");
                                }

                                ent.observActivacion = Convert.ToString(res.reader["observacionesactivacion"]);
                                ent.causa = Convert.ToString(res.reader["causa"]);

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
