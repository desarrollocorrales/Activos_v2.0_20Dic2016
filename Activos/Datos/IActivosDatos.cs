﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Datos
{
    public interface IActivosDatos
    {
        long guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario, string claveActivo, string fecha);

        string obtConsecTipo(int idTipo);

        bool actNumEtiquetaActivo(long idActivo, string numEtiqueta);

        List<Modelos.Activos> getBuscaActivos(int idSucursal, int idArea, int idTipo, string nombre, string status);

        List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq);

        List<Modelos.ActivosDesc> getBuscaActivosResp(int idSucursal, int idArea, int idTipo, string nombre, string status);

        List<Modelos.ActivosDesc> getBuscaActivosResp(string parametro, string tipoBus);

        List<Modelos.ActivosDesc> busquedaUsuariosResponsiva(string usuario, string busqueda);

        bool modificActivo(int? idActivo, string nombre, string descripcion, string fechaIng, int idTipo, int idArea);

        long bajaActivo(int? idActivo, int idMotivo, string motivo, string detalle, string fecha, int idUsuario);

        bool actualizaStatus(long idRB, int? idActivo, string motivo);

        bool actActivoReparacion(int? idReparacion, string observAct, string fechaFin);

        bool cambiaStatusActivo(int? idReparacion, int? idActivo);

        List<int> getActivosIdsRespon(int idResponsiva);

        List<Modelos.Activos> getBuscaActivos(List<int> idActivos);

        List<Modelos.Activos> getBuscaActivosGrupo(int idGrupo);

        List<Modelos.Activos> getBuscaActivosPersona(int idPersona, bool isBaja, bool isRepara);

        List<Modelos.Cambios> getCambios(int idActivo);

        List<Modelos.Activos> getBuscaActivos(int idSucursal, int idArea);

        List<Modelos.Activos> getActivo(long idActivo);

        List<Modelos.Activos> getBuscaActivos(int idResponsiva);

        Modelos.ActivosDesc getActivosDesc(int idActivo);

        List<Modelos.Activos> getActivoSinEstatus(long idActivo);

        List<Modelos.Activos> getActivos(string fecha, int consectraspaso);

        List<Modelos.Activos> getActivosFechas(string fechaIni, string fechaFin, int idSuc, string estatus);
    }
}
