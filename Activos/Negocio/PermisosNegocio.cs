using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Datos;

namespace Activos.Negocio
{
    public class PermisosNegocio : IPermisosNegocio
    {
        IPermisosDatos _permisosDatos;

        public PermisosNegocio()
        {
            this._permisosDatos = new PermisosDatos();
        }

        public List<Modelos.Permisos> getPermisos(int padreId)
        {
            return this._permisosDatos.getPermisos(padreId);
        }


        public List<int> getPermisosUsuario(int idUsuario)
        {
            return this._permisosDatos.getPermisosUsuario(idUsuario);
        }


        public bool actualizaPermisos(int? idUsuario, List<int> permisos)
        {
            return this._permisosDatos.actualizaPermisos(idUsuario, permisos);
        }
    }
}
