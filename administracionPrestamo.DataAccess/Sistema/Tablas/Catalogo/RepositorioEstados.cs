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
            Actualizar(estado);
        }

        public void CrearEstado(Estados estado)
        {
            Crear(estado);
        }

        public void EliminarEstado(Estados estado)
        {
            estado.Estado = false;
            Actualizar(estado);
        }

        public void EliminarFiscamenteEstado(Estados estado)
        {
            EliminarFisicamente(estado);
        }
    }
}
