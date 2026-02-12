using VideoGameHub.Models;

namespace VideoGameHub.Services
{
    public interface IComentarioService
    {
        List<Comentario> GetAll();

        Comentario GetById(int id);

        List<Comentario> GetByVideojuego(int videojuegoId);

        void Crear(Comentario c);

        void Editar(Comentario c);

        void Eliminar(int id);
    }
}
