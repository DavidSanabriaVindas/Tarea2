using VideoGameHub.Data;
using VideoGameHub.Models;

namespace VideoGameHub.Repositories
{
    public class DesarrolladorRepository : IDesarrolladorRepository
    {
        private readonly AppDbContext _context;

        public DesarrolladorRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Desarrollador> GetAll()
            => _context.Desarrolladores.ToList();

        public Desarrollador GetById(int id)
            => _context.Desarrolladores.Find(id);

        public void Add(Desarrollador d)
        {
            _context.Desarrolladores.Add(d);
            _context.SaveChanges();
        }

        public void Update(Desarrollador d)
        {
            _context.Desarrolladores.Update(d);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var d = _context.Desarrolladores.Find(id);
            if (d != null)
            {
                _context.Desarrolladores.Remove(d);
                _context.SaveChanges();
            }
        }
    }
}
