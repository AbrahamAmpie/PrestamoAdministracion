using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioEstados : RepositorioBase<Estados>, IRepositorioEstados
    {
        public RepositorioEstados(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarEstado(Estados estado)
        {
            ActualizarEstado(estado);
        }

        public void CrearEstado(Estados estado)
        {
            CrearEstado(estado);
        }

        public void EliminarEstado(Estados estado)
        {
            estado.Estado = false;
            ActualizarEstado(estado);
        }

        public void EliminarFiscamenteEstado(Estados estado)
        {
            EliminarFiscamenteEstado(estado);
        }
    }
}
