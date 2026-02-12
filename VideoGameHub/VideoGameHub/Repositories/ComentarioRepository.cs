using VideoGameHub.Data;
using VideoGameHub.Models;
using Microsoft.EntityFrameworkCore;

namespace VideoGameHub.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private readonly AppDbContext _context;

        public ComentarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Comentario> GetAll()
            => _context.Comentarios
                .Include(c => c.Videojuego)
                .ToList();

        public Comentario GetById(int id)
            => _context.Comentarios.Find(id);

        public List<Comentario> GetByVideojuego(int videojuegoId)
            => _context.Comentarios
                .Where(c => c.VideojuegoId == videojuegoId)
                .ToList();

        public void Add(Comentario c)
        {
            _context.Comentarios.Add(c);
            _context.SaveChanges();
        }

        public void Update(Comentario c)
        {
            _context.Comentarios.Update(c);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = _context.Comentarios.Find(id);
            if (c != null)
            {
                _context.Comentarios.Remove(c);
                _context.SaveChanges();
            }
        }
    }
}
