using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Prestamo
{
    public interface IRepositorioCuentas : IRepositorioBase<Cuentas>
    {
        void CrearCuenta(Cuentas cuenta);
        void ActualizarCuenta(Cuentas cuenta);
    }
}
