using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioPaises : IRepositorioBase<Paises>
    {
        void CrearPais(Paises pais);
        void ActualizarPais(Paises pais);
        void EliminarPais(Paises pais);
        void EliminarFiscamentePais(Paises pais);
    }
}
