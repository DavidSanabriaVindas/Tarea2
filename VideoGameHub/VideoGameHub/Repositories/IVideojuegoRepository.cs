using VideoGameHub.Models;

namespace VideoGameHub.Repositories
{
    public interface IVideojuegoRepository
    {
        List<Videojuego> GetAll();

        Videojuego GetById(int id);

        void Add(Videojuego v);

        void Update(Videojuego v);

        void Delete(int id);
    }
}