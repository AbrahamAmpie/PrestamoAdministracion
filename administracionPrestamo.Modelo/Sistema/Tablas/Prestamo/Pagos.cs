using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Prestamo
{
    [Table("Pagos", Schema = "prestamo")]
    public class Pagos
    {
        [Key]
        [Column("IdPago")]
        public virtual int IdPago { get; set; }
        public virtual decimal Monto { get; set; }
        public virtual DateTime FechaIngresa { get; set; }
        public virtual string UsuarioResuelve { get; set; }
        public virtual DateTime FechaResuelve { get; set; }
        [ForeignKey("Monedas")]
        public virtual int IdMoneda { get; set; }
        [ForeignKey("Estados")]
        public virtual int IdEstado { get; set; }
        //       IdPago INT IDENTITY(1,1),
        //Monto MONEY NOT NULL,
        //   FechaIngresa DATETIME NOT NULL,
        //UsuarioResuelve NVARCHAR(50) NULL,
        //FechaResuelve DATE NULL,
        //IdMoneda INT NOT NULL,
        //   IdEstado INT NOT NULL,
    }
}
