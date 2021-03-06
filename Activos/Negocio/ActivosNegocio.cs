﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Datos;
using Activos.Modelos;

namespace Activos.Negocio
{
    public class ActivosNegocio : IActivosNegocio
    {
        IActivosDatos _activosDatos;

        public ActivosNegocio()
        {
            this._activosDatos = new ActivosDatos();
        }

        public long guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario, string fecha)
        {
            // define clave de activo
            string consec = this._activosDatos.obtConsecTipo(idTipo);

            string claveActivo = idTipo.ToString().PadLeft(2, '0') + consec;
            
            long idActivo = this._activosDatos.guardaActivo(nombre, descripcion, idArea, idTipo, idUsuario, claveActivo, fecha);

            // define el numero de etiqueta
            string numEtiqueta =
                idTipo.ToString().PadLeft(2, '0') +
                idArea.ToString().PadLeft(2, '0') +
                (idArea.ToString().Length == 3 ? idActivo.ToString().PadLeft(7, '0') : idActivo.ToString().PadLeft(8, '0'));
            
            // obtiene el codigo verificador
            numEtiqueta += Utilerias.getCheckDigit(numEtiqueta);

            this._activosDatos.actNumEtiquetaActivo(idActivo, numEtiqueta);

            return idActivo;
        }


        public List<Modelos.Activos> getBuscaActivos(int idSucursal, int idArea, int idTipo, string nombre, string status)
        {
            return this._activosDatos.getBuscaActivos(idSucursal, idArea, idTipo, nombre, status);
        }


        public List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq)
        {
            return this._activosDatos.getBuscaActivos(parametro, tipoBq);
        }


        public List<ActivosDesc> getBuscaActivosResp(int idSucursal, int idArea, int idTipo, string nombre, string status)
        {
            return this._activosDatos.getBuscaActivosResp(idSucursal, idArea, idTipo, nombre, status);
        }


        public List<ActivosDesc> getBuscaActivosResp(string parametro, string tipoBus)
        {
            return this._activosDatos.getBuscaActivosResp(parametro, tipoBus);
        }


        public List<ActivosDesc> busquedaUsuariosResponsiva(string usuario, string busqueda)
        {
            return this._activosDatos.busquedaUsuariosResponsiva(usuario, busqueda);
        }


        public bool modifActivo(int? idActivo, string nombre, string descripcion, string fechaIng, int idTipo, int idArea)
        {
            return this._activosDatos.modificActivo(idActivo, nombre, descripcion, fechaIng, idTipo, idArea);
        }


        public bool bajaActivo(int? idActivo, int idMotivo, string motivo, string detalle, string fecha, int idUsuario)
        {
            // inserta e activos_reparacion o activos_baja
            long idRB = this._activosDatos.bajaActivo(idActivo, idMotivo, motivo, detalle, fecha, idUsuario);

            // actualizar activos_activos y activos_responsivasdetalle status a 'R' o 'B'
            return this._activosDatos.actualizaStatus(idRB, idActivo, motivo);
        }


        public bool actActivoReparacion(int? idReparacion, string observAct, string fechaFin, int? idActivo)
        {
            bool activa = this._activosDatos.actActivoReparacion(idReparacion, observAct, fechaFin);

            if (activa)
                return this._activosDatos.cambiaStatusActivo(idReparacion, idActivo);
            else
                return false;
        }


        public List<Modelos.Activos> getBuscaActivos(int idResponsiva)
        {
            List<int> idActivos = this._activosDatos.getActivosIdsRespon(idResponsiva);

            if (idActivos.Count == 0) return new List<Modelos.Activos>();

            return this._activosDatos.getBuscaActivos(idActivos);
        }

        public List<Modelos.Activos> getBuscaActivosRepBaja(int idResponsiva)
        {
            return this._activosDatos.getBuscaActivos(idResponsiva);
        }

        public List<Modelos.Activos> getBuscaActivosGrupo(int idGrupo)
        {
            return this._activosDatos.getBuscaActivosGrupo(idGrupo);
        }

        public List<Modelos.Activos> getBuscaActivosPersona(int idPersona, bool isBaja, bool isRepara)
        {
            return this._activosDatos.getBuscaActivosPersona(idPersona, isBaja, isRepara);
        }

        public List<Cambios> getCambios(int idActivo)
        {
            return this._activosDatos.getCambios(idActivo);
        }

        public List<Modelos.Activos> getBuscaActivos(int idSucursal, int idArea)
        {
            return this._activosDatos.getBuscaActivos(idSucursal, idArea);
        }

        public List<Modelos.Activos> getActivo(long idActivo)
        {
            return this._activosDatos.getActivo(idActivo);
        }

        public ActivosDesc getActivoDesc(int idActivo)
        {
            return this._activosDatos.getActivosDesc(idActivo);
        }

        public List<Modelos.Activos> getActivoSinEstatus(long idActivo)
        {
            return this._activosDatos.getActivoSinEstatus(idActivo);
        }

        public List<Modelos.Activos> getActivosTras(string fecha, int consectraspaso)
        {
            return this._activosDatos.getActivos(fecha, consectraspaso);
        }

        public List<Modelos.Activos> getActivosFechas(string fechaIni, string fechaFin, int idSuc, string estatus)
        {
            return this._activosDatos.getActivosFechas(fechaIni, fechaFin, idSuc, estatus);
        }
    }
}
