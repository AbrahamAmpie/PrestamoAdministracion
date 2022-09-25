using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Paises", Schema = "catalogo")]
    public class Paises : EntidadBase
    {
        [Key]
        [Column("IdPais")]
        public virtual int IdPais { get; set; }
        [Column("Nombre")]
        public virtual string Nombre { get; set; }
        [Column("ISO_Numerico")]
        public virtual string ISO_Numerico { get; set; }

        [Column("ISO_Alfa3")]
        public virtual string ISO_Alfa3 { get; set; }
        [Column("Estado")]
        public virtual bool Estado { get; set; }
    }
}
