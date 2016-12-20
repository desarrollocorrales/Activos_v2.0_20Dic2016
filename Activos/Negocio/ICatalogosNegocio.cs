using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;

namespace Activos.Negocio
{
    public interface ICatalogosNegocio
    {
        List<Usuarios> getResponsables();

        List<Sucursales> getSucursales();
    }
}
