using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;

public class FakeProductRepository : FakeEntityRepository<Product>, IProductRepository
{
    public FakeProductRepository(List<Product> entities) : base(entities)
    {
    }

    public List<Product> GetByColor(string color)
    {
        return _entities.Values.Where(p => p.Color == color).ToList();
    }
}