using System;
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

        public bool guardaActivo(string nombre, string descripcion, int idArea, int idTipo, int idUsuario)
        {
            // define clave de activo
            string consec = this._activosDatos.obtConsecTipo(idTipo);

            string claveActivo = idTipo.ToString().PadLeft(2, '0') + consec;
            
            long idActivo = this._activosDatos.guardaActivo(nombre, descripcion, idArea, idTipo, idUsuario, claveActivo);

            // define el numero de etiqueta
            string numEtiqueta =
                idTipo.ToString().PadLeft(2, '0') +
                idArea.ToString().PadLeft(2, '0') +
                idActivo.ToString().PadLeft(8, '0');
            
            // obtiene el codigo verificador
            numEtiqueta += Utilerias.getCheckDigit(numEtiqueta);

            return this._activosDatos.actNumEtiquetaActivo(idActivo, numEtiqueta);
        }


        public List<Modelos.Activos> getBuscaActivos(int idTipo, string nombre, string status)
        {
            return this._activosDatos.getBuscaActivos(idTipo, nombre, status);
        }


        public List<Modelos.Activos> getBuscaActivos(string parametro, string tipoBq)
        {
            return this._activosDatos.getBuscaActivos(parametro, tipoBq);
        }


        public List<ActivosDesc> getBuscaActivosResp(int idTipo, string nombre, string status)
        {
            return this._activosDatos.getBuscaActivosResp(idTipo, nombre, status);
        }


        public List<ActivosDesc> getBuscaActivosResp(string parametro, string tipoBus)
        {
            return this._activosDatos.getBuscaActivosResp(parametro, tipoBus);
        }


        public List<ActivosDesc> busquedaUsuariosResponsiva(string usuario, string busqueda)
        {
            return this._activosDatos.busquedaUsuariosResponsiva(usuario, busqueda);
        }


        public bool modifActivo(int? idActivo, string nombre, string descripcion)
        {
            return this._activosDatos.modificActivo(idActivo, nombre, descripcion);
        }


        public bool bajaActivo(int? idActivo, string motivo, string causa, string fecha, int idUsuario)
        {
            // inserta e activos_reparacion o activos_baja
            long idRB = this._activosDatos.bajaActivo(idActivo, motivo, causa, fecha, idUsuario);

            // actualizar activos_activos y activos_responsivasdetalle status a 'R' o 'B'
            return this._activosDatos.actualizaStatus(idRB, idActivo, motivo);
        }
    }
}
