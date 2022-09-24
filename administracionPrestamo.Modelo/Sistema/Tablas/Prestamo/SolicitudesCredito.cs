using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Prestamo
{
    [Table("SolicitudesCredito", Schema = "prestamo")]
    public class SolicitudesCredito
    {
		[Key]
		[Column("IdSolicitudesCredito")]
		public virtual int IdSolicitudesCredito { get; set; }
        [Column("Monto")]
        public virtual decimal Monto { get; set; }
        [Column("Plazo")]
        public virtual int Plazo { get; set; }
        [Column("CuentaGenerada")]
        public virtual int CuentaGenerada { get; set; }
        [Column("FechaIngresa")]
		public virtual DateTime FechaIngresa { get; set; }
        [Column("UsuarioResuelve")]
        public virtual string UsuarioResuelve { get; set; }
        [Column("FechaResuelve")]
        public virtual DateTime FechaResuelve { get; set; }
        [ForeignKey("Monedas")]
        public virtual int IdMoneda { get; set; }
        [ForeignKey("Estados")]
        public virtual int IdEstado { get; set; }
        [ForeignKey("Solicitantes")]
        public virtual int IdSolicitante { get; set; }
    }
}
