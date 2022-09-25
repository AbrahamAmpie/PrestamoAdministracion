using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Prestamo
{
    public class RepositorioCuentasCuotas : RepositorioBase<CuentasCuotas>, IRepositorioCuentasCuotas
    {
        public RepositorioCuentasCuotas(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarCuentaCuota(CuentasCuotas cuentaCuota)
        {
            ActualizarCuentaCuota(cuentaCuota);
        }

        public void CrearCuentaCuota(CuentasCuotas cuentaCuota)
        {
            CrearCuentaCuota(cuentaCuota);
        }
    }
}
