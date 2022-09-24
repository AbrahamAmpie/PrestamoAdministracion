using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Prestamo
{
    public interface IRepositorioCuentasCuotas : IRepositorioBase<CuentasCuotas>
    {
        void CrearCuentaCuota(CuentasCuotas cuentaCuota);
        void ActualizarCuentaCuota(CuentasCuotas cuentaCuota);
    }
}