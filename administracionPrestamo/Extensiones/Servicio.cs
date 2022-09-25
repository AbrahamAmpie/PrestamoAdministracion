using administracionPrestamo.Contracts.Sistema.Tablas;
using administracionPrestamo.DataAccess;
using administracionPrestamo.DataAccess.Sistema.Tablas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace administracionPrestamo.Extensiones
{
    public static class Servicio
    {
        public static void ConfiguracionRepositorioWrapper(this IServiceCollection servicios)
        {
            servicios.AddScoped<IRepositorioWrapper, RepositorioWrapper>();
        }

        public static void ConfiguracionContextoSql(this IServiceCollection servicios, IConfiguration configuration)
        {
            var CadenaConexion = configuration["ConnectionStrings:ServidorBD"];
            servicios.AddDbContext<Contexto>(o => o.UseSqlServer(CadenaConexion));
        }
    }
}
