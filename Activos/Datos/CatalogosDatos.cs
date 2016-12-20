using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Activos.Datos
{
    public class CatalogosDatos : ICatalogosDatos
    {
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexion;

        public CatalogosDatos()
        {
            // Establece la cadena de conexión
            _conexion = new Conexion(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        }

        // obtiene una lista de todos los usuarios ACTIVOS
        public List<Usuarios> getResponsables()
        {
            List<Usuarios> result = new List<Usuarios>();
            Usuarios ent;

            string sql = "select idusuario, nombre, idpuesto, fechaingreso, correo, usuario, clave, status from activos_usuarios where status = 'A'";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Usuarios();

                            ent.idUsuario = Convert.ToInt16(res.reader["idusuario"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);

                            if (res.reader["idpuesto"] is DBNull) ent.idPuesto = null;
                            else ent.idPuesto = Convert.ToInt16(res.reader["idpuesto"]);

                            ent.fechaIngreso = Convert.ToString(res.reader["fechaingreso"]);
                            ent.correo = Convert.ToString(res.reader["correo"]);
                            ent.usuario = Convert.ToString(res.reader["usuario"]);
                            ent.clave = Convert.ToString(res.reader["clave"]);
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

        // obtiene una lista de todas las sucursales ACTIVAS
        public List<Sucursales> getSucursales()
        {
            List<Sucursales> result = new List<Sucursales>();
            Sucursales ent;

            string sql = "select idsucursal, nombre, idresponsable, status from activos_sucursales where status = 'A'";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Sucursales();

                            ent.idSucursal = Convert.ToInt16(res.reader["idsucursal"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);

                            if (res.reader["idresponsable"] is DBNull) ent.idResponsable = null;
                            else ent.idResponsable = Convert.ToInt16(res.reader["idresponsable"]);

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
