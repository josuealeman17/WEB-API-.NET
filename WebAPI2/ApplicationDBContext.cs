using Microsoft.EntityFrameworkCore;
using WebAPI2.Model;

namespace WebAPI2
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Reemplaza 'Server=localhost' con la dirección de tu servidor MariaDB si es diferente
            // Asegúrate de que la versión del servidor sea la correcta para tu instalación de MariaDB
            optionsBuilder.UseMySql("Server=localhost;Database=MILI;User=root;Password=root;",
                new MariaDbServerVersion(new Version(11, 2, 2)));  // Ajusta la versión según tu instalación
        }

        // Define tus DbSet para cada entidad aquí
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
