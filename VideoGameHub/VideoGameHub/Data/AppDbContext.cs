using Microsoft.EntityFrameworkCore;
using VideoGameHub.Models;

namespace VideoGameHub.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Videojuego> Videojuegos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Desarrollador> Desarrolladores { get; set; }
    }
}
