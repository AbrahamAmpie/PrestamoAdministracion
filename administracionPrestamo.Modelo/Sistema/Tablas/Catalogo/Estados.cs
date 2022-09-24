using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Estados", Schema = "catalogo")]
    public class Estados : EntidadBase
    {
        [Key]
        [Column("IdEstado")]
        public virtual int IdEstado { get; set; }
        [Column("DescripcionEstado")]
        public virtual decimal DescripcionEstado { get; set; }
        [Column("Estado")]
        public virtual bool Estado { get; set; }
    }
}
