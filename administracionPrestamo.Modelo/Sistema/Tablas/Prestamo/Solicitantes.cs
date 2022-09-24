using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace administracionPrestamo.Modelos.Sistema.Tablas.Prestamo
{
    [Table("Solicitantes", Schema = "prestamo")]
    public class Solicitantes
    {
        [Key]
        [Column("IdSolicitante")]
        public virtual int IdSolicitante { get; set; }
        [Column("NumIdentificacion")]
        public virtual string NumIdentificacion { get; set; }
        [Column("PrimerNombre")]
        public virtual string PrimerNombre { get; set; }
        [Column("SegundoNombre")]
        public virtual string SegundoNombre { get; set; }
        [Column("PrimerApellido")]
        public virtual string PrimerApellido { get; set; }
        [Column("SegundoApellido")]
        public virtual string SegundoApellido { get; set; }
        [Column("FechaNacimiento")]
        public virtual DateTime FechaNacimiento { get; set; }
        [ForeignKey("TipoIdentificaciones")]
        public virtual int IdTipoIdentificacion { get; set; }
        [ForeignKey("EstadosCiviles")]
        public virtual int IdEstadoCivil { get; set; }
        [ForeignKey("Paises")]
        public virtual int IdPais { get; set; }
        [ForeignKey("Ciudades")]
        public virtual int IdCiudad { get; set; }
    }
}
