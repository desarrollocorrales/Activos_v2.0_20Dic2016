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
        public List<Usuarios> getPersonas(string status)
        {
            List<Usuarios> result = new List<Usuarios>();
            Usuarios ent;

            string sql =
                "select a.idusuario, pe.idpersona, pe.nombrecompleto as nombre, pe.idpuesto, p.nombre as puesto, a.fechaingreso, a.correo, a.usuario, a.clave, a.status " +
                "from activos_usuarios a " +
                "left join activos_personas pe on (a.idpersona = pe.idpersona)  " +
                "left join activos_puesto p on (pe.idpuesto = p.idpuesto)  " +
                "where a.status = @status order by pe.nombrecompleto";

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

                            if (res.reader["idpersona"] is DBNull) ent.idPersona = null;
                            else ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);

                            if (res.reader["nombre"] is DBNull) ent.nombre = string.Empty;
                            else ent.nombre = Convert.ToString(res.reader["nombre"]).Replace("&", " ");

                            if (res.reader["idpuesto"] is DBNull) ent.idPuesto = null;
                            else ent.idPuesto = Convert.ToInt16(res.reader["idpuesto"]);

                            if (res.reader["puesto"] is DBNull) ent.puesto = string.Empty;
                            else ent.puesto = Convert.ToString(res.reader["puesto"]);

                            DateTime dt = DateTime.Parse(Convert.ToString(res.reader["fechaingreso"]));
                            ent.fechaIngreso = dt.ToString("dd/MM/yyyy");

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

        // valida las credenciales del usuario
        public Usuarios validaAcceso(string usuario, string pass)
        {
            Usuarios result = null;

            string sql = "select idusuario, usuario from activos_usuarios where usuario = @usuario and clave = @clave";

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
                    cmd.Parameters.AddWithValue("@clave", Utilerias.Base64Encode(pass));

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if(res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                result = new Usuarios();

                                result.idUsuario = Convert.ToInt16(res.reader["idusuario"]);

                                result.usuario = Convert.ToString(res.reader["usuario"]);

                            }
                        else result = null;
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
                        "select s.idsucursal, s.nombre, s.idresponsable, p.nombrecompleto as responsable, s.status " +
                        "from activos_sucursales s  " +
                        "left join activos_personas p on (s.idresponsable = p.idpersona)  " +
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
                            else ent.responsable = Convert.ToString(res.reader["responsable"]).Replace("&", " ");

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

        // busquedas usuarios
        public List<UsuariosResponsivas> busquedaUsuarios(string usuario, string busqueda)
        {
            List<UsuariosResponsivas> result = new List<UsuariosResponsivas>();
            UsuariosResponsivas ent;

            string sql = string.Format(
                        "SELECT q.idusuario, q.usuario AS usuario, pe.nombrecompleto as nombre_usuario, p.nombre AS puesto, s.nombre AS sucursal " +
                        "FROM activos_personas pe " +
                        "left join (select idpersona, idusuario, usuario from activos_usuarios where status = 'A') q on (pe.idpersona = q.idpersona) " +
                        "LEFT JOIN activos_puesto p ON (pe.idpuesto = p.idpuesto) " +
                        "LEFT JOIN activos_sucursales s ON (p.idsucursal = s.idsucursal) " +
                        "WHERE pe.status = 'A' and {0} ", 
                        busqueda.Equals("usuario")
                            ? (
                                string.IsNullOrEmpty(usuario) 
                                        ? "(q.idusuario is null or q.usuario LIKE @usuario) order by q.usuario"
                                        : "(q.usuario LIKE @usuario) order by q.usuario"
                              )
                            : "pe.nombrecompleto like @usuario order by pe.nombrecompleto");

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
                        while (res.reader.Read())
                        {
                            ent = new UsuariosResponsivas();

                            ent.idUsuario = Convert.ToInt16(res.reader["idusuario"] == DBNull.Value ? 0 : res.reader["idusuario"]);
                            ent.usuario = Convert.ToString(res.reader["usuario"] == DBNull.Value ? string.Empty : res.reader["usuario"]);

                            ent.nomUsuario = Convert.ToString(res.reader["nombre_usuario"]);
                            ent.nomUsuario = ent.nomUsuario.Replace("&", " ");
                            ent.puesto = Convert.ToString(res.reader["puesto"]);
                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);

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

        // busca si el usuario no existe
        public bool buscaUsuario(string usuario)
        {
            bool result = false;

            string sql = "select count(*) from activos_usuarios where trim(usuario) = @usuario and status = 'A'";

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

            string sql = "select count(*) from activos_usuarios where correo = @correo and status = 'A'";

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
        public bool insertaUsuario(int idPersona, string fecha, string correo, string usuario, string clave)
        {
            string sql = 
                "INSERT INTO activos_usuarios (idpersona, fechaingreso, correo, usuario, clave, status) " + 
                "VALUES (@idPersona, @fecha, @correo, @usuario, @clave, 'A')";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    string claveBase64 = Utilerias.Base64Encode(clave);

                    // define parametros
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", claveBase64);

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
        public bool modificacionUsuario(string correo, int idUsuario)
        {
            string sql = "UPDATE activos_usuarios SET correo=@correo WHERE idusuario=@idUsuario";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
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
                    cmd.Parameters.AddWithValue("@clave", Utilerias.Base64Encode(clave));
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
                    cmd.Parameters.AddWithValue("@clave", Utilerias.Base64Encode(clave));
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

            string sql = "select idarea, nombre from activos_areas where idsucursal = @idsucursal and status = 'A' order by nombre";

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
                        "select idtipo, nombre, marca, modelo, color, serie, status from activos_tipo where status = @status order by nombre";

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

        // selecciona un tipo segun un id
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

        // alta de personas
        public bool altaPersonas(string nombre, int idPuesto)
        {
            string sql = "insert into activos_personas(nombrecompleto, idpuesto, status) values (@nombre, @idpuesto, 'A')";

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
                    cmd.Parameters.AddWithValue("@idpuesto", idPuesto);

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

        // obtiene las personas segun un parametro de busqueda
        public List<Personas> getPersonas(string paramBusq, string status)
        {
            List<Personas> result = new List<Personas>();
            Personas ent;

            string sql =
                        "select p.idpersona, p.nombrecompleto, p.idpuesto, p.status, " +
                        "pu.nombre as puesto, s.nombre as sucursal " +
                        "from activos_personas p " +
                        "left join activos_puesto pu on (p.idpuesto = pu.idpuesto) " +
                        "left join activos_sucursales s on (pu.idsucursal = s.idsucursal) " +
                        "where p.nombrecompleto like @nombre and p.status = @status order by p.nombrecompleto";

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
                    cmd.Parameters.AddWithValue("@nombre", paramBusq.Equals("&") ? "" : "%" + paramBusq + "%");

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Personas();

                            ent.idPuesto = Convert.ToInt16(res.reader["idpuesto"]);
                            ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);

                            ent.nombreCompleto = Convert.ToString(res.reader["nombrecompleto"]);

                            string[] splitNombre = ent.nombreCompleto.Split('&');

                            ent.nombreCompleto = ent.nombreCompleto.Replace("&", " ");
                            
                            ent.nombre = splitNombre[0];
                            ent.apPaterno = splitNombre[1];
                            ent.apMaterno = splitNombre[2];

                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);
                            ent.puesto = Convert.ToString(res.reader["puesto"]);

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

        // modifica una persona
        public bool modifPersona(string nombre, int idPuesto, int? idPersona)
        {
            string sql = "update activos_personas set nombrecompleto = @nombre, idpuesto = @idPuesto where idpersona = @idPers";

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
                    cmd.Parameters.AddWithValue("@idpuesto", idPuesto);
                    cmd.Parameters.AddWithValue("@idPers", idPersona);

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

        // baja a una persona
        public bool bajaPersonas(List<int> seleccionados)
        {
            MySqlTransaction trans;

            string sql = "update activos_personas set status = 'B' where FIND_IN_SET(idpersona, @parameter) != 0";

            bool result = true;

            int rows = 0;

            string wherIn = string.Join(",", seleccionados);

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    trans = conn.BeginTransaction();

                    cmd.Connection = conn;
                    cmd.Transaction = trans;

                    // baja personas
                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    // baja usuarios
                    // define parametros
                    cmd.Parameters.AddWithValue("@parameter", wherIn);

                    sql = "update activos_usuarios set status = 'B' where FIND_IN_SET(idpersona, @parameter) != 0";

                    res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (!res.ok)
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    trans.Commit();

                }
            }

            return result;
        }

        // activa personas
        public bool activaPersonas(List<int> seleccionados)
        {
            string sql = "update activos_personas set status = 'A' where FIND_IN_SET(idpersona, @parameter) != 0";

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

        // obtiene las personas que no tengan usuario
        public List<Personas> getPersonasSinUsuario(string status)
        {
            List<Personas> result = new List<Personas>();
            Personas ent;

            string sql =
                        "select p.idpersona, p.nombrecompleto, p.idpuesto, p.status, pu.nombre as puesto, s.nombre as sucursal " +
                        "from activos_personas p " +
                        "left join activos_usuarios a on (p.idpersona = a.idpersona) " +
                        "left join activos_puesto pu on (p.idpuesto = pu.idpuesto) " +
                        "left join activos_sucursales s on (pu.idsucursal = s.idsucursal) " +
                        "where (a.idusuario is null or a.status != 'A') and p.status = @status " +
                        "group by p.idpersona, p.nombrecompleto, p.idpuesto, p.status, pu.nombre, s.nombre " +
                        "order by p.nombrecompleto";

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
                            ent = new Personas();

                            ent.idPuesto = Convert.ToInt16(res.reader["idpuesto"]);
                            ent.idPersona = Convert.ToInt16(res.reader["idpersona"]);

                            ent.nombreCompleto = Convert.ToString(res.reader["nombrecompleto"]);

                            string[] splitNombre = ent.nombreCompleto.Split('&');

                            ent.nombreCompleto = ent.nombreCompleto.Replace("&", " ");

                            ent.nombre = splitNombre[0];
                            ent.apPaterno = splitNombre[1];
                            ent.apMaterno = splitNombre[2];

                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);
                            ent.puesto = Convert.ToString(res.reader["puesto"]);

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

        // obtiene los motivos de baja
        public List<MotivosBaja> getMotivosBaja()
        {
            List<MotivosBaja> result = new List<MotivosBaja>();
            MotivosBaja ent;

            string sql = "select idmotivobaja, motivo, descripcion, clave, status from activos_motivosbaja";

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
                            ent = new MotivosBaja();

                            ent.idMotivoBaja = Convert.ToInt16(res.reader["idmotivobaja"]);
                            ent.motivo = Convert.ToString(res.reader["motivo"]);
                            ent.descripcion = Convert.ToString(res.reader["descripcion"]);
                            ent.clave = Convert.ToString(res.reader["clave"]);

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

        // agrega un grupo con sus activos
        public bool agregaGrupos(int idUsuario, int idArea, string nombreG, List<Modelos.Activos> activos)
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

                    // crea grupo
                    string sqlG = 
                        "insert into activos_grupos (idarea, nombre, fecha, idusuariocrea, status) " + 
                        "values (@idArea, @nombre, now(), @idUs, 'A')";

                    // define parametros
                    cmd.Parameters.AddWithValue("idArea", idArea);
                    cmd.Parameters.AddWithValue("nombre", nombreG);
                    cmd.Parameters.AddWithValue("idUs", idUsuario);

                    ManejoSql res = Utilerias.EjecutaSQL(sqlG, ref rows, cmd);

                    long idGrupo = 0;

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                        else idGrupo = cmd.LastInsertedId;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    // inserta activos
                    foreach (Modelos.Activos activo in activos)
                    {

                        string sql =
                                "INSERT INTO activos_gruposactivos(idgrupo, idactivo) " +
                                "VALUES (@idGrupo, @idActivo)";

                        // define parametros
                        cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                        cmd.Parameters.AddWithValue("@idActivo", activo.idActivo);

                        res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                        if (!res.ok)
                        {
                            trans.Rollback();
                            throw new Exception(res.numErr + ": " + res.descErr);
                        }

                        cmd.Parameters.Clear();
                    }

                    trans.Commit();
                }
            }

            return result;
        }

        // busca si el activo ya se encuentra en un grupo
        public string buscaActivoEnGrupo(int idActivo)
        {
            string result = string.Empty;

            string sql =
                "select g.nombre grupo from activos_gruposactivos ga " +
                "left join activos_grupos g on (ga.idgrupo = g.idgrupo) " +
                "where idactivo = @idActivo";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idActivo", idActivo);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                result = Convert.ToString(res.reader["grupo"]);
                            }
                        else result = null;
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }

        // busca los grupos
        public List<Grupos> getGrupos(string grupoNombre)
        {
            List<Grupos> result = new List<Grupos>();
            Grupos ent;

            string sql =
                        "select g.idgrupo, g.idarea, g.nombre, g.fecha, g.idusuariocrea, g.status, " +
                               "a.nombre as area, p.nombrecompleto as usuario, a.idsucursal, s.nombre as sucursal " +
                        "from activos_grupos g " +
                        "left join activos_areas a on (g.idarea = a.idarea) " +
                        "left join activos_sucursales s on (a.idsucursal = s.idsucursal) " +
                        "left join activos_usuarios u on (g.idusuariocrea = u.idusuario) " +
                        "left join activos_personas p on (u.idpersona = p.idpersona) " +
                        "where g.nombre like @nombre and g.status = 'A' order by g.nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@nombre", "%" + grupoNombre + "%");

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Grupos();

                            ent.idGrupo = Convert.ToInt16(res.reader["idgrupo"]);
                            ent.idArea = Convert.ToInt16(res.reader["idarea"]);

                            ent.area = Convert.ToString(res.reader["area"]);
                            ent.nombre = Convert.ToString(res.reader["nombre"]);
                            ent.fecha = Convert.ToString(res.reader["fecha"]);

                            ent.idSucursal = Convert.ToInt16(res.reader["idsucursal"]);
                            ent.sucursal = Convert.ToString(res.reader["sucursal"]);

                            ent.idUsuarioCrea = Convert.ToInt16(res.reader["idusuariocrea"]);
                            ent.usuarioCrea = Convert.ToString(res.reader["usuario"]);

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

        // modifica un grupo
        public bool modificaGrupo(int idGrupo, string nombre, List<Modelos.Activos> activos)
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

                    // elimina los activos actuales del grupo
                    string sqlElim = "delete from activos_gruposactivos where idgrupo = @idGrupo";

                    // define parametros
                    cmd.Parameters.AddWithValue("idGrupo", idGrupo);

                    ManejoSql res = Utilerias.EjecutaSQL(sqlElim, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    // inserta activos
                    foreach (Modelos.Activos activo in activos)
                    {

                        string sql =
                                "INSERT INTO activos_gruposactivos(idgrupo, idactivo) " +
                                "VALUES (@idGrupo, @idActivo)";

                        // define parametros
                        cmd.Parameters.AddWithValue("@idGrupo", idGrupo);
                        cmd.Parameters.AddWithValue("@idActivo", activo.idActivo);

                        res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                        if (!res.ok)
                        {
                            trans.Rollback();
                            throw new Exception(res.numErr + ": " + res.descErr);
                        }

                        cmd.Parameters.Clear();
                    }


                    // actualiza grupo
                    string sqlG =
                        "update activos_grupos set nombre = @nombre " +
                        "where idgrupo = @idGrupo";

                    // define parametros
                    cmd.Parameters.AddWithValue("nombre", nombre);
                    cmd.Parameters.AddWithValue("idGrupo", idGrupo);

                    res = Utilerias.EjecutaSQL(sqlG, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();


                    trans.Commit();
                }
            }

            return result;

        }

        // baja de un grupo y sus activos
        public bool bajaGrupo(int idGrupo)
        {
            MySqlTransaction trans;

            string sql = "delete from ";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    trans = conn.BeginTransaction();

                    cmd.Connection = conn;
                    cmd.Transaction = trans;

                    // elimina los activos actuales del grupo
                    string sqlElim = "delete from activos_gruposactivos where idgrupo = @idGrupo";

                    // define parametros
                    cmd.Parameters.AddWithValue("idGrupo", idGrupo);

                    ManejoSql res = Utilerias.EjecutaSQL(sqlElim, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    // baja grupo
                    // elimina los activos actuales del grupo
                    sqlElim = "delete from activos_grupos where idgrupo = @idGrupo";

                    // define parametros
                    cmd.Parameters.AddWithValue("idGrupo", idGrupo);

                    res = Utilerias.EjecutaSQL(sqlElim, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                    {
                        trans.Rollback();
                        throw new Exception(res.numErr + ": " + res.descErr);
                    }

                    cmd.Parameters.Clear();

                    trans.Commit();
                }
            }

            return result;
        }
    }
}
