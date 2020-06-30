using FindSurf.Domain.Entities;

namespace FindSurf.Domain.Repositories
{
    public interface IExampleRepository
    {
        void Create(ExampleEntity todo);
        void Update(ExampleEntity todo);
    }
}
