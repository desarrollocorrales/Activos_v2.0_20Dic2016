using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IReparacionesNegocio
    {
        List<Modelos.Reparaciones> getBuscaActivosReparacion(int idSucursal, int idArea, int idTipo, string nombre);

        List<Modelos.Bajas> getBajasSuc(int idSuc);

        List<Modelos.Reparaciones> getReparaciones(int idSuc);
    }
}
