using BlazorServerApp.Models;

namespace BlazorServerApp.Abstractions;

public interface IProductRepository : IEntityRepository<Product>
{
    List<Product> GetByColor(string color);
}


#endregion