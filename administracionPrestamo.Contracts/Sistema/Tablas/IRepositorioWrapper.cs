using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace administracionPrestamo.Contracts.Sistema.Tablas
{
    public interface IRepositorioWrapper
    {
        #region Sistema
        #region Tablas
        #region Catalogo
        IRepositorioCiudades RepositorioCiudades { get; }
        IRepositorioEstados RepositorioEstados { get; }
        IRepositorioEstadosCiviles RepositorioEstadosCiviles { get; }
        IRepositorioMonedas RepositorioMonedas { get; }
        IRepositorioPaises RepositorioPaises { get; }
        IRepositorioTipoIdentificaciones RepositorioTipoIdentificaciones { get; }
        #endregion

        #region Prestamo
        IRepositorioCuentas RepositorioCuentas { get; }
        IRepositorioCuentasCuotas RepositorioCuentasCuotas { get; }
        IRepositorioPagos RepositorioPagos { get; }
        IRepositorioSolicitantes RepositorioSolicitantes { get; }
        IRepositorioSolicitudesCredito RepositorioSolicitudesCredito { get; }
        #endregion
        #endregion
        #endregion

        Task GuardarAsync();
    }
}
