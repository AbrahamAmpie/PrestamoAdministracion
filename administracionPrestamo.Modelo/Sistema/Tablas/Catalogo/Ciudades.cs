using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Catalogo
{
    [Table("Ciudades", Schema = "catalogo")]
    public class Ciudades : EntidadBase
    {
        [Key]
        [Column("IdCiudad")]
        public virtual int IdCiudad { get; set; }
        [Column("Nombre")]
        public virtual string Nombre { get; set; }
        [Column("Codigo_ISO")]
        public virtual string Codigo_ISO { get; set; }
        [Column("Estado")]
        public virtual bool Estado { get; set; }
        [Column("IdPais")]
        public virtual int IdPais { get; set; }
    }

}
