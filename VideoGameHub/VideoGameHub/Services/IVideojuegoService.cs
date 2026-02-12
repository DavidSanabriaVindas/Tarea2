using VideoGameHub.Models;

namespace VideoGameHub.Services
{
    public interface IVideojuegoService
    {
        List<Videojuego> GetAll();

        Videojuego GetById(int id);

        void Crear(Videojuego v);

        void Editar(Videojuego v);

        void Eliminar(int id);
    }
}