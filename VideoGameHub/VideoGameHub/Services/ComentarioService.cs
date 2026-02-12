using VideoGameHub.Models;
using VideoGameHub.Repositories;

namespace VideoGameHub.Services
{
    public class ComentarioService : IComentarioService
    {
        private readonly IComentarioRepository _repo;

        public ComentarioService(IComentarioRepository repo)
        {
            _repo = repo;
        }

        public List<Comentario> GetAll()
            => _repo.GetAll();

        public Comentario GetById(int id)
            => _repo.GetById(id);

        public List<Comentario> GetByVideojuego(int videojuegoId)
            => _repo.GetByVideojuego(videojuegoId);

        public void Crear(Comentario c)
            => _repo.Add(c);

        public void Editar(Comentario c)
            => _repo.Update(c);

        public void Eliminar(int id)
            => _repo.Delete(id);
    }
}
