using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioCiudades : IRepositorioBase<Ciudades>
    {
        void CrearCiudad(Ciudades ciudad);
        void ActualizarCiudad(Ciudades ciudad);
        void EliminarCiudad(Ciudades ciudad);
        void EliminarFiscamenteCiudad(Ciudades ciudad);
    }
}
