using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;

// Szablon klasy
public class FakeEntityRepository<T> : IEntityRepository<T>
    where T : BaseEntity
{
    protected Dictionary<int, T> _entities = new Dictionary<int, T>();

    public FakeEntityRepository(List<T> entities)
    {
        _entities = entities.ToDictionary(p => p.Id);
    }

    public List<T> GetAll()
    {
        return _entities.Values.ToList();
    }

    public T Get(int id)
    {
        return _entities[id];
    }
}
