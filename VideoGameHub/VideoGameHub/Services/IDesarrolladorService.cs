using VideoGameHub.Models;

namespace VideoGameHub.Services
{
    public interface IDesarrolladorService
    {
        List<Desarrollador> GetAll();

        Desarrollador GetById(int id);

        void Crear(Desarrollador d);

        void Editar(Desarrollador d);

        void Eliminar(int id);
    }
}
