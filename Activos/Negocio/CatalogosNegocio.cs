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

        public List<Usuarios> getResponsables()
        {
            return this._catalogosDatos.getResponsables();
        }


        public List<Sucursales> getSucursales()
        {
            return this._catalogosDatos.getSucursales();
        }
    }
}
