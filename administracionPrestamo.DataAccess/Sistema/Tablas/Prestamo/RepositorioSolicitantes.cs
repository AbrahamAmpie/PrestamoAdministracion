using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Prestamo
{
    public class RepositorioSolicitantes : RepositorioBase<Solicitantes>, IRepositorioSolicitantes
    {
        public RepositorioSolicitantes(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarSolicitante(Solicitantes solicitante)
        {
            ActualizarSolicitante(solicitante);
        }

        public void CrearSolicitante(Solicitantes solicitante)
        {
            CrearSolicitante(solicitante);
        }
    }
}
