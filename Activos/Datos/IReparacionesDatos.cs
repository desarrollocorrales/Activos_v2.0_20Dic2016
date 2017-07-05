using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Datos
{
    public interface IReparacionesDatos
    {
        List<Modelos.Reparaciones> getActivosEnRepar(List<int> activosIds);

        List<Modelos.Bajas> getBajasSuc(int idSuc);

        List<Modelos.Reparaciones> getReparaciones(int idSuc);
    }
}
