using VideoGameHub.Models;

namespace VideoGameHub.Repositories
{
    public interface IComentarioRepository
    {
        List<Comentario> GetAll();

        Comentario GetById(int id);

        List<Comentario> GetByVideojuego(int videojuegoId);

        void Add(Comentario c);

        void Update(Comentario c);

        void Delete(int id);
    }
}
