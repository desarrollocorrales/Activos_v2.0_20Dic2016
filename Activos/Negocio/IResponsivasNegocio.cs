using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activos.Negocio
{
    public interface IResponsivasNegocio
    {

        bool crearResponsivas(List<Modelos.Activos> activos, int idUsuarioCreador, int? idUsuario, string observaciones);

        List<Modelos.Responsivas> buscaResponsiva(string responsable, int idSuc);

        bool modifResponsiva(int? idResponsiva, List<Modelos.Activos> activosMtos);

        List<Modelos.Responsivas> buscaResponsiva(int idUsuario);
    }
}
