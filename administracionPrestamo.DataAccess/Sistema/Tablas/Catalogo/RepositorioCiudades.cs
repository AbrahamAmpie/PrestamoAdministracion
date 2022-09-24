using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioCiudades : RepositorioBase<Ciudades>, IRepositorioCiudades
    {
        public RepositorioCiudades(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarCiudad(Ciudades ciudad)
        {
            ActualizarCiudad(ciudad);
        }

        public void CrearCiudad(Ciudades ciudad)
        {
            CrearCiudad(ciudad);
        }

        public void EliminarCiudad(Ciudades ciudad)
        {
            ciudad.Estado = false;
            ActualizarCiudad(ciudad);
        }

        public void EliminarFiscamenteCiudad(Ciudades ciudad)
        {
            EliminarFiscamenteCiudad(ciudad);
        }
    }
}
