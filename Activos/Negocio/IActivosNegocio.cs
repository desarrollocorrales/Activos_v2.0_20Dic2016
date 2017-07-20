using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IActivosNegocio
    {
        long guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario, string fecha);

        List<Modelos.Activos> getBuscaActivos(int idSucursal, int idArea, int idTipo, string nombre, string status);

        List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq);

        List<Modelos.ActivosDesc> getBuscaActivosResp(int idSucursal, int idArea, int idTipo, string nombre, string status);

        List<Modelos.ActivosDesc> getBuscaActivosResp(string parametro, string tipoBus);

        List<Modelos.ActivosDesc> busquedaUsuariosResponsiva(string usuario, string busqueda);

        bool modifActivo(int? idActivo, string nombre, string descripcion, string fechaIng, int idTipo, int idArea);

        bool bajaActivo(int? idActivo, int idMotivo, string motivo, string detalle, string fecha, int idUsuario);

        bool actActivoReparacion(int? idReparacion, string observAct, string fechaFin, int? idActivo);

        List<Modelos.Activos> getBuscaActivos(int idResponsiva);

        List<Modelos.Activos> getBuscaActivosGrupo(int idGrupo);

        List<Modelos.Activos> getBuscaActivosPersona(int idPersona, bool isBaja, bool isRepara);

        List<Modelos.Cambios> getCambios(int idActivo);

        List<Modelos.Activos> getBuscaActivos(int idSucursal, int idArea);

        List<Modelos.Activos> getActivo(long idActivo);

        List<Modelos.Activos> getBuscaActivosRepBaja(int idResponsiva);

        Modelos.ActivosDesc getActivoDesc(int idActivo);

        List<Modelos.Activos> getActivoSinEstatus(long idActivo);

        List<Modelos.Activos> getActivosTras(string fecha, int consectraspaso);

        List<Modelos.Activos> getActivosFechas(string fechaIni, string fechaFin, int idSuc, string estatus);
    }
}
