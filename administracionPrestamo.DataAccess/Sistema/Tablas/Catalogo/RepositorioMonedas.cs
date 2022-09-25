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
            ActualizarMoneda(moneda);
        }

        public void CrearMoneda(Monedas moneda)
        {
            CrearMoneda(moneda);
        }

        public void EliminarFiscamenteMoneda(Monedas moneda)
        {
            EliminarFiscamenteMoneda(moneda);
        }

        public void EliminarMoneda(Monedas moneda)
        {
            moneda.Estado = false;
            ActualizarMoneda(moneda);
        }
    }
}
