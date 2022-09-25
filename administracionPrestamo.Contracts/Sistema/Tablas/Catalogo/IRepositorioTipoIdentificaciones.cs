using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas.Catalogo
{
    public interface IRepositorioTipoIdentificaciones : IRepositorioBase<TipoIdentificaciones>
    {
        void CrearTipoIdentificacion(TipoIdentificaciones tipoIdentificacion);
        void ActualizarTipoIdentificacion(TipoIdentificaciones tipoIdentificacion);
        void EliminarTipoIdentificacion(TipoIdentificaciones tipoIdentificacion);
        void EliminarFiscamenteTipoIdentificacion(TipoIdentificaciones tipoIdentificacion);
    }
}
