using VideoGameHub.Data;
using VideoGameHub.Models;
using Microsoft.EntityFrameworkCore;

namespace VideoGameHub.Repositories
{
    public class VideojuegoRepository : IVideojuegoRepository
    {
        private readonly AppDbContext _context;

        public VideojuegoRepository(AppDbContext context)
        {
            _context = context;
        }

        // 📌 Obtener todos
        public List<Videojuego> GetAll()
            => _context.Videojuegos
                .Include(v => v.Desarrollador) // relación
                .ToList();

        // 📌 Obtener por Id
        public Videojuego GetById(int id)
            => _context.Videojuegos
                .Include(v => v.Desarrollador)
                .FirstOrDefault(v => v.Id == id);

        // 📌 Crear
        public void Add(Videojuego v)
        {
            _context.Videojuegos.Add(v);
            _context.SaveChanges();
        }

        // 📌 Editar
        public void Update(Videojuego v)
        {
            _context.Videojuegos.Update(v);
            _context.SaveChanges();
        }

        // 📌 Eliminar
        public void Delete(int id)
        {
            var v = _context.Videojuegos.Find(id);

            if (v != null)
            {
                _context.Videojuegos.Remove(v);
                _context.SaveChanges();
            }
        }
    }
}