using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Prestamo
{
    public interface IRepositorioPagos : IRepositorioBase<Pagos>
    {
        void CrearPago(Pagos pago);
        void ActualizarPago(Pagos pago);
    }
}
