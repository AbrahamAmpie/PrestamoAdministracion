using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioMonedas : RepositorioBase<Monedas>, IRepositorioMonedas
    {
        public RepositorioMonedas(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarMoneda(Monedas moneda)
        {
            Actualizar(moneda);
        }

        public void CrearMoneda(Monedas moneda)
        {
            Crear(moneda);
        }

        public void EliminarFiscamenteMoneda(Monedas moneda)
        {
            EliminarFisicamente(moneda);
        }

        public void EliminarMoneda(Monedas moneda)
        {
            moneda.Estado = false;
            Actualizar(moneda);
        }
    }
}
