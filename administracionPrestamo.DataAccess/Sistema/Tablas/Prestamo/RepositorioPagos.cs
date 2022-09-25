using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Prestamo
{
    public class RepositorioPagos : RepositorioBase<Pagos>, IRepositorioPagos
    {
        public RepositorioPagos(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarPago(Pagos pago)
        {
            ActualizarPago(pago);
        }

        public void CrearPago(Pagos pago)
        {
            CrearPago(pago);
        }
    }
}
