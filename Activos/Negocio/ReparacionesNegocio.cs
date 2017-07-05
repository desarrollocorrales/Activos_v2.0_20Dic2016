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

        public List<Modelos.Reparaciones> getBuscaActivosReparacion(int idSucursal, int idArea, int idTipo, string nombre)
        {
            List<Modelos.ActivosDesc> activos = this._activosDatos.getBuscaActivosResp(idSucursal, idArea, idTipo, nombre, "R");

            if (activos.Count == 0)
                return new List<Modelos.Reparaciones>();

            return this._reparacionesDatos.getActivosEnRepar(activos.Select(s => s.idActivo).ToList());
            
        }

        public List<Modelos.Bajas> getBajasSuc(int idSuc)
        {
            return this._reparacionesDatos.getBajasSuc(idSuc);
        }

        public List<Modelos.Reparaciones> getReparaciones(int idSuc)
        {
            return this._reparacionesDatos.getReparaciones(idSuc);
        }
    }
}
