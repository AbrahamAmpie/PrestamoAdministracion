using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioEstadosCiviles : RepositorioBase<EstadosCiviles>, IRepositorioEstadosCiviles
    {
        public RepositorioEstadosCiviles(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarEstadoCivil(EstadosCiviles estadoCivil)
        {
            ActualizarEstadoCivil(estadoCivil);
        }

        public void CrearEstadoCivil(EstadosCiviles estadoCivil)
        {
            CrearEstadoCivil(estadoCivil);
        }

        public void EliminarEstadoCivil(EstadosCiviles estadoCivil)
        {
            estadoCivil.Estado = false;
            EliminarEstadoCivil(estadoCivil);
        }

        public void EliminarFiscamenteEstadoCivil(EstadosCiviles estadoCivil)
        {
            EliminarFiscamenteEstadoCivil(estadoCivil);
        }
    }
}
