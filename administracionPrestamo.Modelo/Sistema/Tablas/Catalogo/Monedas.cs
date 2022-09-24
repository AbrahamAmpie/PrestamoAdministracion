using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Monedas", Schema = "catalogo")]
    public class Monedas
    {
        [Key]
        [Column("IdMoneda")]
        public virtual int IdMoneda { get; set; }
        [Column("Nombre")]
        public virtual int Nombre { get; set; }
        [Column("Codigo_ISO")]
        public virtual int Codigo_ISO { get; set; }
        [Column("IdPais")]
        public virtual int IdPais { get; set; }
    }
}
