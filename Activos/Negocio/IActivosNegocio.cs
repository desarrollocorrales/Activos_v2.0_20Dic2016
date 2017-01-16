using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IActivosNegocio
    {
        bool guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int p);

        List<Modelos.Activos> getBuscaActivos(int idTipo, string nombre, string status);

        List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq);

        List<Modelos.ActivosDesc> getBuscaActivosResp(int idTipo, string nombre, string status);

        List<Modelos.ActivosDesc> getBuscaActivosResp(string parametro, string tipoBus);

        List<Modelos.ActivosDesc> busquedaUsuariosResponsiva(string usuario, string busqueda);

        bool modifActivo(int? idActivo, string nombre, string descripcion);

        bool bajaActivo(int? idActivo, int idMotivo, string motivo, string detalle, string fecha, int idUsuario);

        bool actActivoReparacion(int? idReparacion, string observAct, string fechaFin, int? idActivo);

        List<Modelos.Activos> getBuscaActivos(int idResponsiva);
    }
}
