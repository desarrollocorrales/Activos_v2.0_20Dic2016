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

        public bool crearResponsivas(List<Modelos.Activos> activos, int idUsuarioCreador, int? idUsuario, string observaciones)
        {
            long idResult = this._responsivasDatos.crearResponsivas(idUsuarioCreador, idUsuario, observaciones);

            if(idResult == 0) return false;

            return this._responsivasDatos.creaRespDet(idResult, activos);
        }
    }
}
