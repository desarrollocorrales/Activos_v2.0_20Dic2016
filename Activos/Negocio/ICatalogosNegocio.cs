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
        List<Usuarios> getResponsables(string status);

        Response creaUsuario(string nombre, int idPuesto, string fecha, string correo, string usuario, string clave);

        bool modificacionUsuario(string nombre, int idPuesto, string fecIng, string correo, int idUsuario);

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

        bool agregaTipo(string p, int marca, int modelo, int serie, int color);

        bool activaTipos(List<int> seleccionados);

        bool bajaTipos(List<int> seleccionados);

        bool modificaTipo(int idTipo, string nombre, int marca, int modelo, int serie, int color);



        
    }
}
