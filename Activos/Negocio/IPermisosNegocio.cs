using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IPermisosNegocio
    {
        List<Modelos.Permisos> getPermisos(int padreId);

        List<int> getPermisosUsuario(int idUsuario);

        bool actualizaPermisos(int? idUsuario, List<int> permisos);

        bool guardaUrl(string url, bool nuevaUrl);
    }
}
