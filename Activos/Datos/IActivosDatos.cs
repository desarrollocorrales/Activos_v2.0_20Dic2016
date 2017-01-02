using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Datos
{
    public interface IActivosDatos
    {
        long guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario, string claveActivo);

        string obtConsecTipo(int idTipo);

        bool actNumEtiquetaActivo(long idActivo, string numEtiqueta);

        List<Modelos.Activos> getBuscaActivos(int idTipo, string nombre);

        List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq);
    }
}
