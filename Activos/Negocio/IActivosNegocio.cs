using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IActivosNegocio
    {
        bool guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int p);

        List<Modelos.Activos> getBuscaActivos(int idTipo, string nombre);

        List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq);
    }
}
