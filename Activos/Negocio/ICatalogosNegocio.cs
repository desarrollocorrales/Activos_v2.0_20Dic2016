using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Activos.Modelos;

namespace Activos.Negocio
{
    public interface ICatalogosNegocio
    {
        /* ******** S U C U R S A L E S ************ */
        List<Sucursales> getSucursales(string status);

        bool agregaSucursal(string sucNom, int? idResp);

        bool bajaSucursalas(List<int> seleccionados);

        bool modificaSucursal(string sucNom, int? idResp, int p);

        bool activaSucursalas(List<int> seleccionados);


        /* ************* P U E S T O S ************* */
        List<Puestos> getPuestos(string status);

        bool agregaPuesto(string puestoNom, int idSuc);

        bool bajaPuestos(List<int> seleccionados);

        bool activaPuestos(List<int> seleccionados);

        bool modificaPuesto(string puestoNom, int idSuc, int idPuesto);


        /* ********** U S U A R I O  S ************* */
        Response validaAcceso(string usuario, string pass);

        List<Usuarios> getPersonas(string status);

        List<PersonaResponsivas> busquedaResponsables(string persona);

        List<PersonaResponsivas> busquedaResponsables(string persona, int idsucursal);

        Response creaUsuario(int idPersona, string fecha, string correo, string usuario, string clave);

        bool modificacionUsuario(string correo, int idUsuario);

        bool activaUsuarios(List<int> seleccionados);

        bool bajaUsuarios(List<int> seleccionados);

        bool validaClave(string clave, int idUsuario);

        bool actualizaClave(string clave, int idUsuario);


        /* ************* A R E A S *************** */
        List<Areas> getAreas(string status);

        List<Areas> getAreas(int idSuc);

        bool agregaArea(string areaNom, int idSuc);

        bool activaAreas(List<int> seleccionados);

        bool bajaAreas(List<int> seleccionados);

        bool modificaArea(string areaNom, int idSuc, int idArea);


        /* ************* T I P O S *************** */
        List<Tipos> getTipos(string status);

        Tipos getTipo(int idTipo);

        bool agregaTipo(string nombre, int marca, int modelo, int serie, int color, int costo, int factura);

        bool activaTipos(List<int> seleccionados);

        bool bajaTipos(List<int> seleccionados);

        bool modificaTipo(int idTipo, string nombre, int marca, int modelo, int serie, int color, int costo, int factura);



        /* ********** P E R S O N A S *********** */
        bool altaPersona(string nombre, int idPuesto);

        List<Personas> getPersonas(string paramBusq, string status);

        bool modifPersona(string nombre, int idPuesto, int? idPersona);

        bool bajaPersonas(List<int> seleccionados);

        bool activaPersonas(List<int> seleccionados);

        List<Modelos.Personas> getPersonasSinUsuario(string status);



        /* ****** M O T I V O S   B A J A ****** */
        List<Modelos.MotivosBaja> getMotivosBaja();



        /* ************ G R U P O S ************ */
        bool agregaGrupo(int idUsuario, int idArea, string nombreG, List<Modelos.Activos> activos);

        string buscaActivoEnGrupo(int idActivo);

        List<Grupos> getGrupos(string grupoNombre);

        bool modificaGrupo(int idGrupo, string nombre, List<Modelos.Activos> activos);

        bool bajaGrupo(int idGrupo);


        List<PersonaResponsivas> busquedaUsuarios(string usuario);

        /* ************ L O G O S ************ */
        List<Modelos.UsoLogos> getUsosLogos();

        List<Logo> getLogos(int idUso, string status);

        bool seleccionarLogo(int idLogo, UsoLogos uso);

        bool subirLogo(UsoLogos uso, string nombre, string descripcion, string observaciones, bool seleccionar, byte[] logo);

        string getUrl(string clave);

        string getSucursal(int? idPersona);
    }
}
