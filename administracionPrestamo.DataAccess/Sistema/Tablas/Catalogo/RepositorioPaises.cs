using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioPaises : RepositorioBase<Paises>, IRepositorioPaises
    {
        public RepositorioPaises(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarPais(Paises pais)
        {
            Actualizar(pais);
        }

        public void CrearPais(Paises pais)
        {
            Crear(pais);
        }

        public void EliminarFiscamentePais(Paises pais)
        {
            EliminarFisicamente(pais);
        }

        public void EliminarPais(Paises pais)
        {
            pais.Estado = false;
            Actualizar(pais);
        }
    }
}
