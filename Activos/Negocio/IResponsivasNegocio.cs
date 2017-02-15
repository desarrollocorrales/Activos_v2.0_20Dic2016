using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IResponsivasNegocio
    {

        bool crearResponsivas(List<Modelos.Activos> activos, int idUsuarioCreador, int? idUsuario, string observaciones, List<Modelos.PersonaResponsivas> responsables);

        List<Modelos.Responsivas> buscaResponsiva(string responsable, int idSuc, string tipoCons);

        bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos, List<int> idsResp);

        List<Modelos.Responsivas> buscaResponsiva(int idUsuario);

        bool traspasoRespExist(List<Modelos.Activos> activosAnterior, int? idUsuarioN, int? idUsuarioA, string motivo, List<Modelos.Activos> activosTraspaso, int? idRespTraspaso, int? idResponsiva);

        bool traspasoCreaResp(List<Modelos.Activos> activosAnterior, int? idUsuarioA, string motivo, List<Modelos.Activos> activosTraspaso, int? idResponsiva, string observaciones, int? idUsuario, int idUsCrea);

        bool bajaResponsiva(int? idResponsiva, string motivo);

        string getBuscaComandoEt(string etiqueta);

        List<Modelos.PersonaResponsivas> obtieneResponsables(int idResponsiva);

        List<Modelos.PersonaResponsivas> buscaResponsiva(string responsable, int idSuc);

        bool traspasoResponsiva(int? idResponsiva, int? idPersonaAnt, int? idPersonaNueva, List<Modelos.Activos> activos, string motivo);

        Modelos.RespPorFolio obtieneRespXFolio(int folio);

        Modelos.Logo obtieneLogo(string clave);

        List<Modelos.ResponsivasSucursal> getRespSuc(int idSuc, bool bajas, bool repara);
    }
}
