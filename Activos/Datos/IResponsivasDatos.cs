using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Datos
{
    public interface IResponsivasDatos
    {
        long crearResponsivas(int idUsuarioCreador, int? idUsuario, string observaciones);

        bool creaRespDet(long idResult, List<Modelos.Activos> activos);

        List<Modelos.Responsivas> buscaResponsiva(string responsable, int idSuc);

        bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos);

        List<Modelos.Responsivas> buscaResponsiva(int idUsuario);
    }
}
