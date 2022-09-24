using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioEstadosCiviles : IRepositorioBase<EstadosCiviles>
    {
        void CrearEstadoCivil(EstadosCiviles estadoCivil);
        void ActualizarEstadoCivil(EstadosCiviles estadoCivil);
        void EliminarEstadoCivil(EstadosCiviles estadoCivil);
        void EliminarFiscamenteEstadoCivil(EstadosCiviles estadoCivil);
    }
}
