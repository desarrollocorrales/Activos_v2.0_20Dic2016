using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Datos;
using Activos.Modelos;

namespace Activos.Negocio
{
    public class CatalogosNegocio : ICatalogosNegocio
    {
        ICatalogosDatos _catalogosDatos;

        public CatalogosNegocio()
        {
            this._catalogosDatos = new CatalogosDatos();
        }


        /* ******** S U C U R S A L E S ************ */
        public List<Sucursales> getSucursales(string status)
        {
            return this._catalogosDatos.getSucursales(status);
        }


        public bool agregaSucursal(string sucNom, int? idResp)
        {
            return this._catalogosDatos.agregaSucursal(sucNom, idResp);
        }


        public bool bajaSucursalas(List<int> seleccionados)
        {
            return this._catalogosDatos.bajaSucursales(seleccionados);
        }


        public bool modificaSucursal(string sucNom, int? idResp, int idSucursal)
        {
            return this._catalogosDatos.modificaSucursal(sucNom, idResp, idSucursal);
        }


        public bool activaSucursalas(List<int> seleccionados)
        {
            return this._catalogosDatos.activaSucursales(seleccionados);
        }


        /* ************* P U E S T O S ************* */
        public List<Puestos> getPuestos(string status)
        {
            return this._catalogosDatos.getPuestos(status);
        }


        public bool agregaPuesto(string puestoNom, int idSuc)
        {
            return this._catalogosDatos.agregaPuestos(puestoNom, idSuc);
        }


        public bool bajaPuestos(List<int> seleccionados)
        {
            return this._catalogosDatos.bajaPuestos(seleccionados);
        }


        public bool activaPuestos(List<int> seleccionados)
        {
            return this._catalogosDatos.activaPuestos(seleccionados);
        }


        public bool modificaPuesto(string puestoNom, int idSuc, int idPuesto)
        {
            return this._catalogosDatos.modificaPuesto(puestoNom, idSuc, idPuesto);
        }



        /* ********** U S U A R I O  S ************* */
        public List<Usuarios> getResponsables(string status)
        {
            return this._catalogosDatos.getResponsables(status);
        }

        public Response creaUsuario(string nombre, int idPuesto, string fecha, string correo, string usuario, string clave)
        {
            Response result = new Response();

            // buscar si el usuario ya existe
            bool us = this._catalogosDatos.buscaUsuario(usuario.Trim().ToLower());

            if (us)
            {
                result.status = Estatus.ERROR;
                result.error = "El usuario ya existe";
                return result;
            }

            // buscar si el correo existe
            bool corr = this._catalogosDatos.buscaCorreo(correo.Trim().ToLower());

            if (corr)
            {
                result.status = Estatus.ERROR;
                result.error = "El correo ya se registro para otro usuario";
                return result;
            }

            // inserta el usuario
            bool inserta = this._catalogosDatos.insertaUsuario(nombre, idPuesto, fecha, correo, usuario, clave);

            result.status = Estatus.OK;

            return result;
        }


        public bool modificacionUsuario(string nombre, int idPuesto, string fecIng, string correo, int idUsuario)
        {
            return this._catalogosDatos.modificacionUsuario(nombre, idPuesto, fecIng, correo, idUsuario);
        }


        public bool activaUsuarios(List<int> seleccionados)
        {
            return this._catalogosDatos.activaUsuarios(seleccionados);
        }


        public bool bajaUsuarios(List<int> seleccionados)
        {
            return this._catalogosDatos.bajaUsuarios(seleccionados);
        }


        public bool validaClave(string clave, int idUsuario)
        {
            return this._catalogosDatos.validaClave(clave, idUsuario);
        }


        public bool actualizaClave(string clave, int idUsuario)
        {
            return this._catalogosDatos.actualizaClave(clave, idUsuario);
        }


        /* ************* A R E A S *************** */
        public List<Areas> getAreas(string status)
        {
            return this._catalogosDatos.getAreas(status);
        }

        public List<Areas> getAreas(int idSuc)
        {
            return this._catalogosDatos.getAreas(idSuc);
        }

        public bool agregaArea(string areaNom, int idSuc)
        {
            return this._catalogosDatos.agregaAreas(areaNom, idSuc);
        }


        public bool activaAreas(List<int> seleccionados)
        {
            return this._catalogosDatos.activaAreas(seleccionados);
        }


        public bool bajaAreas(List<int> seleccionados)
        {
            return this._catalogosDatos.bajaAreas(seleccionados);
        }


        public bool modificaArea(string areaNom, int idSuc, int idArea)
        {
            return this._catalogosDatos.modificaArea(areaNom, idSuc, idArea);
        }


        /* ************* T I P O S *************** */
        public List<Tipos> getTipos(string status)
        {
            return this._catalogosDatos.getTipos(status);
        }


        public Tipos getTipo(int idTipo)
        {
            return this._catalogosDatos.getTipos(idTipo);
        }


        public bool agregaTipo(string nombre, int marca, int modelo, int serie, int color)
        {
            return this._catalogosDatos.agregaTipo(nombre, marca, modelo, serie, color);
        }


        public bool activaTipos(List<int> seleccionados)
        {
            return this._catalogosDatos.activaTipos(seleccionados);
        }


        public bool bajaTipos(List<int> seleccionados)
        {
            return this._catalogosDatos.bajaTipos(seleccionados);
        }


        public bool modificaTipo(int idTipo, string nombre, int marca, int modelo, int serie, int color)
        {
            return this._catalogosDatos.modificaTipo(idTipo, nombre, marca, modelo, serie, color);
        }


    }
}
