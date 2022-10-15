using itSenseDomain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace itSensePersistencia
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        {
        }

        public DbSet<Producto>? Productos { get; set; }


    }
}