using VideoGameHub.Models;
using VideoGameHub.Repositories;

namespace VideoGameHub.Services
{
    public class VideojuegoService : IVideojuegoService
    {
        private readonly IVideojuegoRepository _repo;

        public VideojuegoService(IVideojuegoRepository repo)
        {
            _repo = repo;
        }

        public List<Videojuego> GetAll()
            => _repo.GetAll();

        public Videojuego GetById(int id)
            => _repo.GetById(id);

        public void Crear(Videojuego v)
            => _repo.Add(v);

        public void Editar(Videojuego v)
            => _repo.Update(v);

        public void Eliminar(int id)
            => _repo.Delete(id);
    }
}