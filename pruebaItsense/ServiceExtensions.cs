
using itSensePersistencia;
using Microsoft.EntityFrameworkCore;

namespace pruebaItsense
{
    public static class ServiceExtensions
    {
        public static void ConfiguracionConexionSQL(this IServiceCollection servicios, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");

            servicios.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString,
                b => b.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
        }
    }
}
