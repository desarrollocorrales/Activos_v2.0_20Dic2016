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
        public List<Usuarios> getResponsables(string status)
        {
            List<Usuarios> result = new List<Usuarios>();
            Usuarios ent;

            string sql = 
                "select a.idusuario, a.nombre, a.idpuesto, p.nombre as puesto, a.fechaingreso, a.correo, a.usuario, a.clave, a.status  " +
                "from activos_usuarios a " +
                "left join activos_puesto p on (a.idpuesto = p.idpuesto)  " +
                "where a.status = @status";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@status", status);

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

                            if (res.reader["puesto"] is DBNull) ent.puesto = string.Empty;
                            else ent.puesto = Convert.ToString(res.reader["puesto"]);

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
        public List<Sucursales> getSucursales(string status)
        {
            List<Sucursales> result = new List<Sucursales>();
            Sucursales ent;

            string sql = 
                        "select s.idsucursal, s.nombre, s.idresponsable, u.nombre as responsable, s.status  " +
                        "from activos_sucursales s  " +
                        "left join activos_usuarios u on (s.idresponsable = u.idusuario)  " +
                        "where s.status = @status order by s.nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@status", status);

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

                            if (res.reader["responsable"] is DBNull) ent.responsable = "";
                            else ent.responsable = Convert.ToString(res.reader["responsable"]);

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

        // agrega una nueva sucursal
        public bool agregaSucursal(string sucNom, int? idResp)
        {
            string sql = "insert into activos_sucursales(nombre, idresponsable, status) values (@nombre, @idresponsable, 'A')";

            bool result = true;

            int rows = 0;
            
            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", sucNom);
                    cmd.Parameters.AddWithValue("@idresponsable", idResp == null ? (object)DBNull.Value : idResp.ToString());

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

        // baja a una sucursal o varias
        public bool bajaSucursales(List<int> seleccionados)
        {
            string sql = "update activos_sucursales set status = 'B' where FIND_IN_SET(idsucursal, @parameter) != 0";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // actualiza una sucursal
        public bool modificaSucursal(string sucNom, int? idResp, int idSucursal)
        {
            string sql = "update activos_sucursales set nombre = @nombre, idresponsable = @idResp where idsucursal = @idSuc";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", sucNom);
                    cmd.Parameters.AddWithValue("@idResp", idResp == null ? (object)DBNull.Value : idResp.ToString());
                    cmd.Parameters.AddWithValue("@idSuc", idSucursal);

                    ManejoSql res = Utilerias.EjecutaSQL(string.Format(sql, sucNom, idResp == null ? "null" : idResp.ToString(), idSucursal), ref rows, cmd);

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

        // activa sucursales
        public bool activaSucursales(List<int> seleccionados)
        {
            string sql = "update activos_sucursales set status = 'A' where FIND_IN_SET(idsucursal, @parameter) != 0 ";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // obtiene los puestos
        public List<Puestos> getPuestos(string status)
        {
            List<Puestos> result = new List<Puestos>();
            Puestos ent;

            string sql = 
                        "select p.idpuesto, p.nombre, p.idsucursal, s.nombre as sucursal, p.status   " +
                        "from activos_puesto p  " +
                        "left join activos_sucursales s on (p.idsucursal = s.idsucursal)  " +
                        "where p.status = @status order by p.idsucursal, p.nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@status", status);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Puestos();

                            ent.idSucursal = Convert.ToInt16(res.reader["idsucursal"]);
                            ent.idPuesto = Convert.ToInt16(res.reader["idpuesto"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);

                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);

                            ent.status = Convert.ToString(res.reader["status"]);

                            ent.nom_suc = ent.sucursal + " - " + ent.nombre;

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

        // inserta un nuevo puesto
        public bool agregaPuestos(string puestoNom, int idSuc)
        {
            string sql = "insert into activos_puesto(nombre, idsucursal, status) values (@nombre, @idsuc, 'A')";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", puestoNom);
                    cmd.Parameters.AddWithValue("@idsuc", idSuc);

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

        // baja a un puesto o varios
        public bool bajaPuestos(List<int> seleccionados)
        {
            string sql = "update activos_puesto set status = 'B' where FIND_IN_SET(idpuesto, @parameter) != 0 ";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // activar puestos
        public bool activaPuestos(List<int> seleccionados)
        {
            string sql = "update activos_puesto set status = 'A' where FIND_IN_SET(idpuesto, @parameter) != 0 ";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // actualiza puesto
        public bool modificaPuesto(string puestoNom, int idSuc, int idPuesto)
        {
            string sql = "update activos_puesto set nombre = @nombre, idsucursal = @idSuc where idpuesto = @idPuesto";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", puestoNom);
                    cmd.Parameters.AddWithValue("@idSuc", idSuc);
                    cmd.Parameters.AddWithValue("@idPuesto", idPuesto);

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

        // busca si el usuario no existe
        public bool buscaUsuario(string usuario)
        {
            bool result = false;

            string sql = "select count(*) from activos_usuarios where usuario = @usuario";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    
                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            int count = Convert.ToInt16(res.reader[0]);

                            if (count > 0) result = true;
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

        // busca un correo en usuarios
        public bool buscaCorreo(string correo)
        {
            bool result = false;

            string sql = "select count(*) from activos_usuarios where correo = @correo";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@correo", correo);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            int count = Convert.ToInt16(res.reader[0]);

                            if (count > 0) result = true;
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

        // inserta un nuevo usuario
        public bool insertaUsuario(string nombre, int idPuesto, string fecha, string correo, string usuario, string clave)
        {
            string sql = 
                "INSERT INTO activos_usuarios (nombre, idpuesto, fechaingreso, correo, usuario, clave, status) " + 
                "VALUES (@nombre, @idPuesto, @fecha, @correo, @usuario, @clave, 'A')";

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
                    cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);

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

        // modifica usuarios
        public bool modificacionUsuario(string nombre, int idPuesto, string fecIng, string correo, int idUsuario)
        {
            string sql = "UPDATE activos_usuarios SET nombre=@nombre, idpuesto=@idPuesto, fechaingreso=@fecha, correo=@correo WHERE idusuario=@idUsuario";

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
                    cmd.Parameters.AddWithValue("@idPuesto", idPuesto);
                    cmd.Parameters.AddWithValue("@fecha", fecIng);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

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

        // activar usuarios
        public bool activaUsuarios(List<int> seleccionados)
        {

            string sql = "update activos_usuarios set status = 'A' where FIND_IN_SET(idusuario, @parameter) != 0 ";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // baja a usuarios
        public bool bajaUsuarios(List<int> seleccionados)
        {
            string sql = "update activos_usuarios set status = 'B' where FIND_IN_SET(idusuario, @parameter) != 0 ";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // valida la clave
        public bool validaClave(string clave, int idUsuario)
        {
            bool result = false;

            string sql = "select count(*) from activos_usuarios where clave = @clave and idusuario = @idUsuario";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            int count = Convert.ToInt16(res.reader[0]);

                            if (count > 0) result = true;
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

        // actualiza clave
        public bool actualizaClave(string clave, int idUsuario)
        {
            string sql = "update activos_usuarios set clave = @clave where idusuario = @idUsuario";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

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

        // regresa las areas segun un estatus
        public List<Areas> getAreas(string status)
        {
            List<Areas> result = new List<Areas>();
            Areas ent;

            string sql = 
                        "select a.idarea, a.nombre, a.idsucursal, s.nombre as sucursal, a.status " +
                        "from activos_areas a " +
                        "left join activos_sucursales s on (a.idsucursal = s.idsucursal) " +
                        "where a.status = @status order by a.idsucursal, a.nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@status", status);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Areas();

                            ent.idSucursal = Convert.ToInt16(res.reader["idsucursal"]);
                            ent.idArea = Convert.ToInt16(res.reader["idarea"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);

                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);

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

        // regresa las areas segun una sucursal
        public List<Areas> getAreas(int idSuc)
        {
            List<Areas> result = new List<Areas>();
            Areas ent;

            string sql = "select idarea, nombre from activos_areas where idsucursal = @idsucursal and status = 'A'";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idsucursal", idSuc);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Areas();

                            ent.idArea = Convert.ToInt16(res.reader["idarea"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);

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

        // agrega areas
        public bool agregaAreas(string areaNom, int idSuc)
        {
            string sql = "insert into activos_areas(nombre, idsucursal, status) values (@nombre, @idSucu, 'A')";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", areaNom);
                    cmd.Parameters.AddWithValue("@idSucu", idSuc);

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

        // activa areas seleccionadas
        public bool activaAreas(List<int> seleccionados)
        {
            string sql = "update activos_areas set status = 'A' where FIND_IN_SET(idarea, @parameter) != 0";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // baja areas
        public bool bajaAreas(List<int> seleccionados)
        {
            string sql = "update activos_areas set status = 'B' where FIND_IN_SET(idarea, @parameter) != 0";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // modifica area
        public bool modificaArea(string areaNom, int idSuc, int idArea)
        {
            string sql = "update activos_areas set nombre = @nombre, idsucursal = @idSucu where idarea = @idArea";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", areaNom);
                    cmd.Parameters.AddWithValue("@idSucu", idSuc);
                    cmd.Parameters.AddWithValue("@idArea", idArea);

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

        // obtiene los tipos segun un estatus
        public List<Tipos> getTipos(string status)
        {
            List<Tipos> result = new List<Tipos>();
            Tipos ent;

            string sql = 
                        "select idtipo, nombre, marca, modelo, color, serie, status from activos_tipo where status = @status";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@status", status);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Tipos();

                            ent.idTipo = Convert.ToInt16(res.reader["idtipo"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);

                            ent.marca = Convert.ToString(res.reader["marca"]).Equals("0") ? "NO" : "SI";
                            ent.modelo = Convert.ToString(res.reader["modelo"]).Equals("0") ? "NO" : "SI";
                            ent.serie = Convert.ToString(res.reader["serie"]).Equals("0") ? "NO" : "SI";
                            ent.color = Convert.ToString(res.reader["color"]).Equals("0") ? "NO" : "SI";

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

        public Tipos getTipos(int idTipo)
        {
            Tipos result = new Tipos();

            string sql = "select idtipo, nombre, marca, modelo, color, serie, status from activos_tipo where idtipo = @idtipo";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idtipo", idTipo);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            result = new Tipos();

                            result.idTipo = Convert.ToInt16(res.reader["idtipo"]);
                            result.nombre = Convert.ToString(res.reader["nombre"]);

                            result.marca = Convert.ToString(res.reader["marca"]).Equals("0") ? "NO" : "SI";
                            result.modelo = Convert.ToString(res.reader["modelo"]).Equals("0") ? "NO" : "SI";
                            result.serie = Convert.ToString(res.reader["serie"]).Equals("0") ? "NO" : "SI";
                            result.color = Convert.ToString(res.reader["color"]).Equals("0") ? "NO" : "SI";

                            result.status = Convert.ToString(res.reader["status"]);
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

        // agrega tipo
        public bool agregaTipo(string nombre, int marca, int modelo, int serie, int color)
        {
            string sql = 
                "INSERT INTO activos_tipo (nombre, marca, modelo, color, serie, status) " + 
                "VALUES (@nombre, @marca, @modelo, @color, @serie, 'A')";

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
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@serie", serie);

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

        // activar tipos
        public bool activaTipos(List<int> seleccionados)
        {
            string sql = "update activos_tipo set status = 'A' where FIND_IN_SET(idtipo, @parameter) != 0";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // baja tipos
        public bool bajaTipos(List<int> seleccionados)
        {
            string sql = "update activos_tipo set status = 'B' where FIND_IN_SET(idtipo, @parameter) != 0";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

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

        // modifica tipos
        public bool modificaTipo(int idTipo, string nombre, int marca, int modelo, int serie, int color)
        {

            string sql = 
                "UPDATE activos_tipo " + 
                "SET nombre = @nombre, marca = @marca, modelo = @modelo, color = @color, serie = @serie WHERE idtipo = @idTipo";

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
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@serie", serie);
                    cmd.Parameters.AddWithValue("@idTipo", idTipo);

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
