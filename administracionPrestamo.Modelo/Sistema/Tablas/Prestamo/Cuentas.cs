using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Prestamo
{
    [Table("Cuentas", Schema = "prestamo")]
    public class Cuentas
    {
		[Key]
		[Column("IdCuenta")]
		public virtual string IdCuenta { get; set; }
        [Column("MontoAprobado")]
        public virtual decimal MontoAprobado { get; set; }
        [Column("PlazoAprobado")]
        public virtual int PlazoAprobado { get; set; }
        [Column("TasaInteres")]
        public virtual decimal TasaInteres { get; set; }
        [Column("MontoCapital")]
        public virtual decimal MontoCapital { get; set; }
        [Column("MontoInteres")]
        public virtual decimal MontoInteres { get; set; }
        [Column("TotalPagar")]
        public virtual decimal TotalPagar { get; set; }
        [Column("Estado")]
        public virtual bool Estado { get; set; }
        [ForeignKey("SolicitudesCredito")]
        public virtual int IdSolicitudesCredito { get; set; }
    }
}
