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


        public bool traspasoRespExist(List<Modelos.Activos> activosTraspaso, int? idRespTraspaso, int? idResponsiva)
        {
            return this._responsivasDatos.traspasoRespExist(activosTraspaso, idRespTraspaso, idResponsiva);
        }


        public bool traspasoCreaResp(List<Modelos.Activos> activosTraspaso, int? idResponsiva, string observaciones, int? idUsuario, int idUsCrea)
        {
            return this._responsivasDatos.traspasoCreaResp(activosTraspaso, idResponsiva, observaciones, idUsuario, idUsCrea);
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
    }
}
