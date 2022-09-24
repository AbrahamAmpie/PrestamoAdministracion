using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Catalogo
{
    [Table("TipoIdentificaciones", Schema = "catalogo")]
    public class TipoIdentificaciones : EntidadBase
    {
        [Key]
        [Column("IdTipoIdentificacion")]
        public virtual int IdTipoIdentificacion { get; set; }
        [Column("Descripcion")]
        public virtual string Descripcion { get; set; }
    }
}
