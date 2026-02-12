using VideoGameHub.Models;
using VideoGameHub.Repositories;

namespace VideoGameHub.Services
{
    public class DesarrolladorService : IDesarrolladorService
    {
        private readonly IDesarrolladorRepository _repo;

        public DesarrolladorService(IDesarrolladorRepository repo)
        {
            _repo = repo;
        }

        public List<Desarrollador> GetAll()
            => _repo.GetAll();

        public Desarrollador GetById(int id)
            => _repo.GetById(id);

        public void Crear(Desarrollador d)
            => _repo.Add(d);

        public void Editar(Desarrollador d)
            => _repo.Update(d);

        public void Eliminar(int id)
            => _repo.Delete(id);
    }
}
