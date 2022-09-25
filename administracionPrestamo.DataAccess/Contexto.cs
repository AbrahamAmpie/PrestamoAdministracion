using administracionPrestamo.Modelos.Sistema;
using administracionPrestamo.Modelos.Sistema.Tablas.Catalogo;
using administracionPrestamo.Modelos.Sistema.Tablas.Prestamo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace administracionPrestamo.DataAccess
{
    public class Contexto : DbContext
    {
        public static class ContextBD
        {
            public static string CadenaConexion { get; set; }
        }

        private string cadenaConexion { get; set; }

        public Contexto(DbContextOptions opciones) : base(opciones)
        {
            var constructor = new ConfigurationBuilder();
            constructor.AddJsonFile("appsettings.json", optional: false);

            var configuracion = constructor.Build();
            cadenaConexion = configuracion.GetConnectionString("ServidorBD").ToString();
            ContextBD.CadenaConexion = cadenaConexion;
        }

        protected override void OnModelCreating(ModelBuilder constructorModelo)
        {
            base.OnModelCreating(constructorModelo);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opcionesConstructor)
        {
            opcionesConstructor.UseSqlServer(cadenaConexion);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken tokenCancelacion = default)
        {
            var ListaEntradas = ChangeTracker.Entries().Where(x => x.Entity is EntidadBase);

            ListaEntradas.ToList().ForEach(delegate (EntityEntry EntradaEntidad)
            {
                EntidadBase Entidad = EntradaEntidad.Entity as EntidadBase;

                if (EntradaEntidad.State == EntityState.Added)
                {
                    Entidad.FechaRegistra = DateTime.Now;
                    Entidad.FechaActualiza = DateTime.Now;
                    Entidad.UsuarioRegistra = "";
                    Entidad.UsuarioActualiza = "";
                } else if (EntradaEntidad.State == EntityState.Modified)
                {
                    Entidad.FechaActualiza = DateTime.Now;
                    Entidad.UsuarioActualiza = "";
                }
            });

            return await base.SaveChangesAsync();
        }

        #region DbSet Sistema
        #region Tablas
        #region Catalogo
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Estados> Estados { get; set; }
        public DbSet<EstadosCiviles> EstadosCiviles { get; set; }
        public DbSet<Monedas> Monedas { get; set; }
        public DbSet<Paises> Paises { get; set; }
        public DbSet<TipoIdentificaciones> TipoIdentificaciones { get; set; }
        #endregion

        #region Prestamo
        public DbSet<Cuentas> Cuentas { get; set; }
        public DbSet<CuentasCuotas> CuentasCuotas { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Solicitantes> Solicitantes { get; set; }
        public DbSet<SolicitudesCredito> SolicitudesCreditos { get; set; }
        #endregion
        #endregion
        #endregion
    }
}
