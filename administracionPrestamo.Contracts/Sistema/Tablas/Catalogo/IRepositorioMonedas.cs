using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioMonedas : IRepositorioBase<Monedas>
    {
        void CrearMoneda(Monedas moneda);
        void ActualizarMoneda(Monedas moneda);
        void EliminarMoneda(Monedas moneda);
        void EliminarFiscamenteMoneda(Monedas moneda);
    }
}
