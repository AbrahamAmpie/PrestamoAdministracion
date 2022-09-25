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
            Actualizar(tipoIdentificacion);
        }

        public void CrearTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            Crear(tipoIdentificacion);
        }

        public void EliminarFiscamenteTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            EliminarFisicamente(tipoIdentificacion);
        }

        public void EliminarTipoIdentificacion(TipoIdentificaciones tipoIdentificacion)
        {
            tipoIdentificacion.Estado = false;
            Actualizar(tipoIdentificacion);
        }
    }
}
