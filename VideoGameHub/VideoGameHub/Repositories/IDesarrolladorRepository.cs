using VideoGameHub.Models;

namespace VideoGameHub.Repositories
{
    public interface IDesarrolladorRepository
    {
        List<Desarrollador> GetAll();

        Desarrollador GetById(int id);

        void Add(Desarrollador d);

        void Update(Desarrollador d);

        void Delete(int id);
    }
}
