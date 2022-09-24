using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Prestamo
{
    public interface IRepositorioSolicitantes : IRepositorioBase<Solicitantes>
    {
        void CrearSolicitante(Solicitantes solicitante);
        void ActualizarSolicitante(Solicitantes solicitante);
    }
}
