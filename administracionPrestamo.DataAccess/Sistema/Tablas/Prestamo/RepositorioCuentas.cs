using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Prestamo
{
    public class RepositorioCuentas : RepositorioBase<Cuentas>, IRepositorioCuentas
    {
        public RepositorioCuentas(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarCuenta(Cuentas cuenta)
        {
            Actualizar(cuenta);
        }

        public void CrearCuenta(Cuentas cuenta)
        {
            Crear(cuenta);
        }
    }
}
