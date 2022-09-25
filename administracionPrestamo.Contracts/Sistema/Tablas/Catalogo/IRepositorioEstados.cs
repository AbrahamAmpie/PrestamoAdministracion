using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioEstados : IRepositorioBase<Estados>
    {
        void CrearEstado(Estados estado);
        void ActualizarEstado(Estados estado);
        void EliminarEstado(Estados estado);
        void EliminarFiscamenteEstado(Estados estado);
    }
}
