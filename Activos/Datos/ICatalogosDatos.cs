using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;

namespace Activos.Datos
{
    public interface ICatalogosDatos
    {
        List<Usuarios> getResponsables();

        List<Sucursales> getSucursales();
    }
}
