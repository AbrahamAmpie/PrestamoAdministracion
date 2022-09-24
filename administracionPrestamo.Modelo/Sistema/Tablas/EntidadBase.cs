using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace administracionPrestamo.Modelos.Sistema
{
    public class EntidadBase
    {
        [Column("UsuarioRegistra")]
        public virtual string UsuarioRegistra { get; set; }
        [Column("FechaRegistra")]
        public virtual DateTime FechaRegistra { get; set; }
        [Column("UsuarioActualiza")]
        public virtual string UsuarioActualiza { get; set; }
        [Column("FechaActualiza")]
        public virtual DateTime FechaActualiza { get; set; }
    }
}
