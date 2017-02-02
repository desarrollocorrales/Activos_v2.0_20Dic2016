using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Datos
{
    public interface IResponsivasDatos
    {
        long crearResponsivas(int idUsuarioCreador, int? idUsuario, string observaciones);

        bool creaRespDet(long idResult, List<Modelos.Activos> activos, List<Modelos.PersonaResponsivas> responsables);

        List<Modelos.Responsivas> buscaResponsiva(string responsable, int idSuc, string tipoCons);

        bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos);

        List<Modelos.Responsivas> buscaResponsiva(int idUsuario);

        bool traspasoRespExist(List<Modelos.Activos> activosTraspaso, int? idRespTraspaso, int? idResponsiva);

        bool traspasoCreaResp(List<Modelos.Activos> activosTraspaso, int? idResponsiva, string observaciones, int? idUsuario, int idUsCrea);

        bool bajaResponsiva(int? idResponsiva, string motivo);

        string getBuscaComandoEt(string etiqueta);

        List<Modelos.PersonaResponsivas> obtieneResponsables(int idResponsiva);
    }
}
