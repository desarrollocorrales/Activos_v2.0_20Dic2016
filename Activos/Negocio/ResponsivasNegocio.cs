using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Datos;

namespace Activos.Negocio
{
    public class ResponsivasNegocio : IResponsivasNegocio
    {
        IResponsivasDatos _responsivasDatos;
        IActivosDatos _activosDatos;

        public ResponsivasNegocio()
        {
            this._responsivasDatos = new ResponsivasDatos();
        }

        public bool crearResponsivas(List<Modelos.Activos> activos, int idUsuarioCreador, int? idUsuario, string observaciones, List<Modelos.PersonaResponsivas> responsables)
        {
            long idResult = this._responsivasDatos.crearResponsivas(idUsuarioCreador, idUsuario, observaciones);

            if(idResult == 0) return false;

            return this._responsivasDatos.creaRespDet(idResult, activos, responsables);
        }


        public List<Modelos.Responsivas> buscaResponsiva(string responsable, int idSuc, string tipoCons)
        {
            return this._responsivasDatos.buscaResponsiva(responsable, idSuc, tipoCons);
        }


        public bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos, List<int> idsResp)
        {
            return this._responsivasDatos.modifResponsiva(idResponsiva, activosMtos, idsResp);
        }


        public List<Modelos.Responsivas> buscaResponsiva(int idUsuario)
        {
            return this._responsivasDatos.buscaResponsiva(idUsuario);
        }


        public bool traspasoRespExist(List<Modelos.Activos> activosAnterior, int? idUsuarioN, int? idUsuarioA, string motivo, List<Modelos.Activos> activosTraspaso, int? idRespTraspaso, int? idResponsiva)
        {
            return this._responsivasDatos.traspasoRespExist(activosAnterior, idUsuarioN, idUsuarioA, motivo,  activosTraspaso, idRespTraspaso, idResponsiva);
        }


        public bool traspasoCreaResp(List<Modelos.Activos> activosAnterior, int? idUsuarioA, string motivo, List<Modelos.Activos> activosTraspaso, int? idResponsiva, string observaciones, int? idUsuario, int idUsCrea)
        {
            return this._responsivasDatos.traspasoCreaResp(activosAnterior, idUsuarioA, motivo, activosTraspaso, idResponsiva, observaciones, idUsuario, idUsCrea);
        }


        public bool bajaResponsiva(int? idResponsiva, string motivo)
        {
            return this._responsivasDatos.bajaResponsiva(idResponsiva, motivo);
        }


        public string getBuscaComandoEt(string etiqueta)
        {
            return this._responsivasDatos.getBuscaComandoEt(etiqueta);
        }


        public List<Modelos.PersonaResponsivas> obtieneResponsables(int idResponsiva)
        {
            return this._responsivasDatos.obtieneResponsables(idResponsiva);
        }


        public List<Modelos.PersonaResponsivas> buscaResponsiva(string responsable, int idSuc)
        {
            return this._responsivasDatos.buscaResponsiva(responsable, idSuc);
        }


        public bool traspasoResponsiva(int? idResponsiva, int? idPersonaAnt, int? idPersonaNueva, List<Modelos.Activos> activos, string motivo)
        {
            return this._responsivasDatos.traspasoResponsiva(idResponsiva, idPersonaAnt, idPersonaNueva, activos, motivo);
        }


        public Modelos.RespPorFolio obtieneRespXFolio(int folio)
        {

            Modelos.RespPorFolio result = new Modelos.RespPorFolio();

            result.responsiva = this._responsivasDatos.getRespXFolio(folio);

            if (result.responsiva == null) return null;

            this._activosDatos = new ActivosDatos();

            List<int> idActivos = this._activosDatos.getActivosIdsRespon(result.responsiva.idResponsiva);

            if (idActivos.Count == 0) return null;
            
            result.activos = this._activosDatos.getBuscaActivos(idActivos);

            return result;
        }

        public Modelos.Logo obtieneLogo(string clave)
        {
            return this._responsivasDatos.obtieneLogo(clave);
        }

        public List<Modelos.ResponsivasSucursal> getRespSuc(int idSuc, bool bajas, bool repara)
        {
            return this._responsivasDatos.getRespSuc(idSuc, bajas, repara);
        }

        public List<Modelos.Responsivas> getResponsivas(string tipoCons)
        {
            return this._responsivasDatos.getResponsivas(tipoCons);
        }

        public List<Modelos.Responsivas> buscaRespXSuc(int idSuc)
        {
            return this._responsivasDatos.buscaRespXSuc(idSuc);
        }

        public List<Modelos.Responsivas> getRespPersonas(int? idPresona)
        {
            return this._responsivasDatos.getRespPersonas(idPresona);
        }


        public List<Modelos.Traspasos> getTraspasos(string fecha)
        {
            return this._responsivasDatos.getTraspasos(fecha);
        }
    }
}
