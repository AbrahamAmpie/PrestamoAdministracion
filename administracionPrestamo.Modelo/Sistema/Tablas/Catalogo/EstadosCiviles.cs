using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Catalogo
{
    [Table("EstadosCivil", Schema = "catalogo")]
    public class EstadosCiviles : EntidadBase
    {
        [Key]
        [Column("IdEstadoCivil")]
        public virtual int IdEstadoCivil { get; set; }
        [Column("Descripcion")]
        public virtual string Descripcion { get; set; }
        [Column("Estado")]
        public virtual bool Estado { get; set; }
    }
}
