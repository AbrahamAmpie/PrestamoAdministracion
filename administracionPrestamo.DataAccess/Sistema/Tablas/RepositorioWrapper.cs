using administracionPrestamo.Contracts.Sistema.Tablas;
using administracionPrestamo.Contracts.Sistema.Tablas.Catalogo;
using administracionPrestamo.Contracts.Sistema.Tablas.Prestamo;
using administracionPrestamo.DataAccess.Sistema.Tablas.Catalogo;
using administracionPrestamo.DataAccess.Sistema.Tablas.Prestamo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace administracionPrestamo.DataAccess.Sistema.Tablas
{
    public class RepositorioWrapper : IRepositorioWrapper
    {
        private Contexto _repositorioContexto;

        #region Sistema
        #region Tablas
        #region Catalogo
        private IRepositorioCiudades _ciudades;
        private IRepositorioEstados _estados;
        private IRepositorioEstadosCiviles _estadosCiviles;
        private IRepositorioMonedas _monedas;
        private IRepositorioPaises _paises;
        private IRepositorioTipoIdentificaciones _tipoIdentificacion;
        #endregion

        #region Prestamo
        private IRepositorioCuentas _cuentas;
        private IRepositorioCuentasCuotas _cuentasCuota;
        private IRepositorioPagos _pagos;
        private IRepositorioSolicitantes _solicitantes;
        private IRepositorioSolicitudesCredito _solicitudesCredito;
        #endregion
        #endregion
        #endregion

        public RepositorioWrapper(Contexto contexto)
        {
            _repositorioContexto = contexto;
        }

        #region Sistema
        #region Tablas
        #region Catalogo
        public IRepositorioCiudades RepositorioCiudades
        {
            get
            {
                if(_ciudades == null)
                {
                    _ciudades = new RepositorioCiudades(_repositorioContexto);
                }

                return _ciudades;
            }
        }

        public IRepositorioEstados RepositorioEstados
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new RepositorioEstados(_repositorioContexto);
                }

                return _estados;
            }
        }

        public IRepositorioEstadosCiviles RepositorioEstadosCiviles
        {
            get
            {
                if (_estadosCiviles == null)
                {
                    _estadosCiviles = new RepositorioEstadosCiviles(_repositorioContexto);
                }

                return _estadosCiviles;
            }
        }

        public IRepositorioMonedas RepositorioMonedas
        {
            get
            {
                if (_monedas == null)
                {
                    _monedas = new RepositorioMonedas(_repositorioContexto);
                }

                return _monedas;
            }
        }

        public IRepositorioPaises RepositorioPaises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new RepositorioPaises(_repositorioContexto);
                }

                return _paises;
            }
        }

        public IRepositorioTipoIdentificaciones RepositorioTipoIdentificaciones
        {
            get
            {
                if (_tipoIdentificacion == null)
                {
                    _tipoIdentificacion = new RepositorioTipoIdentificaciones(_repositorioContexto);
                }

                return _tipoIdentificacion;
            }
        }
        #endregion IRepositorioTipoIdentificaciones

        #region Prestamo
        public IRepositorioCuentas RepositorioCuentas
        {
            get
            {
                if (_cuentas == null)
                {
                    _cuentas = new RepositorioCuentas(_repositorioContexto);
                }

                return _cuentas;
            }
        }

        public IRepositorioCuentasCuotas RepositorioCuentasCuotas
        {
            get
            {
                if (_cuentasCuota == null)
                {
                    _cuentasCuota = new RepositorioCuentasCuotas(_repositorioContexto);
                }

                return _cuentasCuota;
            }
        }

        public IRepositorioPagos RepositorioPagos
        {
            get
            {
                if (_pagos == null)
                {
                    _pagos = new RepositorioPagos(_repositorioContexto);
                }

                return _pagos;
            }
        }

        public IRepositorioSolicitantes RepositorioSolicitantes
        {
            get
            {
                if (_solicitantes == null)
                {
                    _solicitantes = new RepositorioSolicitantes(_repositorioContexto);
                }

                return _solicitantes;
            }
        }

        public IRepositorioSolicitudesCredito RepositorioSolicitudesCredito
        {
            get
            {
                if (_solicitudesCredito == null)
                {
                    _solicitudesCredito = new RepositorioSolicitudesCredito(_repositorioContexto);
                }

                return _solicitudesCredito;
            }
        }
        #endregion
        #endregion
        #endregion

        public async Task GuardarAsync()
        {
            await _repositorioContexto.SaveChangesAsync();
        }
    }
}
