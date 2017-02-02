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
        public Response validaAcceso(string usuario, string pass)
        {
            Response result = new Response();
            result.status = Estatus.OK;

            // buscar si el usuario ya existe
            bool us = this._catalogosDatos.buscaUsuario(usuario.Trim().ToLower());

            if (!us)
            {
                result.status = Estatus.ERROR;
                result.error = "El usuario no existe";
                return result;
            }

            Usuarios resultado = this._catalogosDatos.validaAcceso(usuario, pass);

            if (resultado == null)
            {
                result.status = Estatus.ERROR;
                result.error = "Contraseña incorrecta";
                return result;
            }

            result.usuario = resultado;

            return result;
        }

        public List<Usuarios> getPersonas(string status)
        {
            return this._catalogosDatos.getPersonas(status);
        }

        public List<PersonaResponsivas> busquedaResponsables(string persona)
        {
            return this._catalogosDatos.busquedaResponsables(persona);
        }

        public List<PersonaResponsivas> busquedaResponsables(string persona, int idSucursal)
        {
            return this._catalogosDatos.busquedaResponsables(persona, idSucursal);
        }

        public Response creaUsuario(int idPersona, string fecha, string correo, string usuario, string clave)
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
            bool inserta = this._catalogosDatos.insertaUsuario(idPersona, fecha, correo, usuario, clave);

            result.status = Estatus.OK;

            return result;
        }


        public bool modificacionUsuario(string correo, int idUsuario)
        {
            return this._catalogosDatos.modificacionUsuario(correo, idUsuario);
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




        /* ********** P E R S O N A S *********** */
        public bool altaPersona(string nombre, int idPuesto)
        {
            return this._catalogosDatos.altaPersonas(nombre, idPuesto);
        }


        public List<Personas> getPersonas(string paramBusq, string status)
        {
            return this._catalogosDatos.getPersonas(paramBusq, status);
        }


        public bool modifPersona(string nombre, int idPuesto, int? idPersona)
        {
            return this._catalogosDatos.modifPersona(nombre, idPuesto, idPersona);
        }


        public bool bajaPersonas(List<int> seleccionados)
        {
            return this._catalogosDatos.bajaPersonas(seleccionados);
        }


        public bool activaPersonas(List<int> seleccionados)
        {
            return this._catalogosDatos.activaPersonas(seleccionados);
        }


        public List<Personas> getPersonasSinUsuario(string status)
        {
            return this._catalogosDatos.getPersonasSinUsuario(status);
        }


        public List<MotivosBaja> getMotivosBaja()
        {
            return this._catalogosDatos.getMotivosBaja();
        }


        public bool agregaGrupo(int idUsuario, int idArea, string nombreG, List<Modelos.Activos> activos)
        {
            return this._catalogosDatos.agregaGrupos(idUsuario, idArea, nombreG, activos);
        }


        public string buscaActivoEnGrupo(int idActivo)
        {
            return this._catalogosDatos.buscaActivoEnGrupo(idActivo);
        }


        public List<Grupos> getGrupos(string grupoNombre)
        {
            return this._catalogosDatos.getGrupos(grupoNombre);
        }


        public bool modificaGrupo(int idGrupo, string nombre, List<Modelos.Activos> activos)
        {
            return this._catalogosDatos.modificaGrupo(idGrupo, nombre, activos);
        }


        public bool bajaGrupo(int idGrupo)
        {
            return this._catalogosDatos.bajaGrupo(idGrupo);
        }


        public List<PersonaResponsivas> busquedaUsuarios(string usuario)
        {
            return this._catalogosDatos.busquedaUsuario(usuario);
        }
    }
}
