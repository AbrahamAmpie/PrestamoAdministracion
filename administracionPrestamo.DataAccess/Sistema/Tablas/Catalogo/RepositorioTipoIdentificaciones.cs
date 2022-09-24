using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo
{
    public class RepositorioTipoIdentificaciones : RepositorioBase<TipoIdentificaciones>, IRepositorioTipoIdentificaciones
    {
        public RepositorioTipoIdentificaciones(Contexto repositorioContexto) : base(repositorioContexto) { }

        public void ActualizarTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            ActualizarTipoIdentificacion(tipoIdentificacion);
        }

        public void CrearTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            CrearTipoIdentificacion(tipoIdentificacion);
        }

        public void EliminarFiscamenteTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            EliminarFiscamenteTipoIdentificacion(tipoIdentificacion);
        }

        public void EliminarTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            tipoIdentificacion.Estado = false;
            ActualizarTipoIdentificacion(tipoIdentificacion);
        }
    }
}
