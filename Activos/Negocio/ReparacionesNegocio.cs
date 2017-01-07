using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Datos;

namespace Activos.Negocio
{
    public class ReparacionesNegocio : IReparacionesNegocio
    {
        IReparacionesDatos _reparacionesDatos;
        IActivosDatos _activosDatos;

        public ReparacionesNegocio()
        {
            this._reparacionesDatos = new ReparacionesDatos();
            this._activosDatos = new ActivosDatos();
        }

        public List<Modelos.Reparaciones> getBuscaActivosReparacion(int idTipo, string nombre)
        {
            List<Modelos.ActivosDesc> activos = this._activosDatos.getBuscaActivosResp(idTipo, nombre, "R");

            if (activos.Count == 0)
                return new List<Modelos.Reparaciones>();

            return this._reparacionesDatos.getActivosEnRepar(activos.Select(s => s.idActivo).ToList());
            
        }
    }
}
