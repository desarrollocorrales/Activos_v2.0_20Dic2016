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
    }
}
