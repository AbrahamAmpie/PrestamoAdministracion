using administracionPrestamo.Contracts.Sistema.Tablas;
using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Prestamo
{
    public class RepositorioSolicitudesCredito : RepositorioBase<SolicitudesCredito>, IRepositorioSolicitudesCredito
    {
        public RepositorioSolicitudesCredito(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarSolicitudCredito(SolicitudesCredito solicitudCredito)
        {
            Actualizar(solicitudCredito);
        }

        public void CrearSolicitudCredito(SolicitudesCredito solicitudCredito)
        {
            Crear(solicitudCredito);
        }
    }
}
