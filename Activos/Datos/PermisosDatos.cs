using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;
using MySql.Data.MySqlClient;

namespace Activos.Datos
{
    public class PermisosDatos : IPermisosDatos
    {
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexion;

        public PermisosDatos()
        {
            // Establece la cadena de conexión
            _conexion = new Conexion(Modelos.ConectionString.conn);
        }

        // regresa los permisos segun un padreId
        List<Permisos> IPermisosDatos.getPermisos(int padreId)
        {
            List<Permisos> result = new List<Permisos>();
            Permisos ent;

            string sql =
                        "select p.idpermiso, p.descripcion, p.padreid " +
                        "from activos_permisos p where p.padreid = @padreId";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@padreId", padreId);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Permisos();

                            ent.idPermiso = Convert.ToInt16(res.reader["idpermiso"]);

                            ent.padreId = Convert.ToInt16(res.reader["padreid"]);
                            ent.descripcion = Convert.ToString(res.reader["descripcion"]);
                            
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

        // obtiene los permisos de un usuario
        public List<int> getPermisosUsuario(int idUsuario)
        {
            List<int> result = new List<int>();

            string sql = "select idpermiso, idpermisousuario, idusuario from activos_permisosusuarios where idusuario = @idUsuario";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            result.Add(Convert.ToInt16(res.reader["idpermiso"]));
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

        // actualiza permisos de un usuario
        public bool actualizaPermisos(int? idUsuario, List<int> permisos)
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

                    sql = "delete from activos_permisosusuarios where idusuario = @idUsuario";

                    // define parametros
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (!res.ok)
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    foreach (int perm in permisos)
                    {
                       
                        sql =
                            "INSERT INTO activos_permisosusuarios(idusuario, idpermiso) " +
                            "VALUES (@idUsuario, @idPermiso)";
                        
                        // define parametros
                        cmd.Parameters.AddWithValue("@idPermiso", perm);
                        cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                        res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

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
    }
}
