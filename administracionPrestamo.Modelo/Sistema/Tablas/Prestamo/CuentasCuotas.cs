using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Prestamo
{
    [Table("CuentasCuotas", Schema = "prestamo")]
    public class CuentasCuotas
    {
        [Key]
        [Column("IdCuentaCuota")]
        public virtual int IdCuentaCuota { get; set; }
        [Column("NumeroCuota")]
        public virtual int NumeroCuota { get; set; }
        [Column("SaldoCapital")]
        public virtual decimal SaldoCapital { get; set; }
        [Column("SaldoInteres")]
        public virtual decimal SaldoInteres { get; set; }
        [Column("FechaCuota")]
        public virtual DateTime FechaCuota { get; set; }
        [Column("FechaMaximaPago")]
        public virtual DateTime FechaMaximaPago { get; set; }
        [Column("FechaIngresa")]
        public virtual DateTime FechaIngresa { get; set; }
        [ForeignKey("Cuentas")]
        public virtual int IdCuenta { get; set; }
    }
}
