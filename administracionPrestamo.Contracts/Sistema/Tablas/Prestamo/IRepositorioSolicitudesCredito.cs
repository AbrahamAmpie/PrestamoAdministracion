using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Prestamo
{
    public interface IRepositorioSolicitudesCredito : IRepositorioBase<SolicitudesCredito>
    {
        void CrearSolicitudCredito(SolicitudesCredito solicitudCredito);
        void ActualizarSolicitudCredito(SolicitudesCredito solicitudCredito);
    }
}
