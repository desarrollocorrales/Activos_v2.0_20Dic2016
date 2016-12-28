using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Datos;

namespace Activos.Negocio
{
    public class ActivosNegocio : IActivosNegocio
    {
        IActivosDatos _activosDatos;

        public ActivosNegocio()
        {
            this._activosDatos = new ActivosDatos();
        }

        public bool guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario)
        {
            return this._activosDatos.guardaActivo(nombre, descripcion, idArea, idTipo, idUsuario);
        }
    }
}
