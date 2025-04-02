using BlazorServerApp.Models;
using Bogus;

namespace BlazorServerApp.Fakers;

public class ProductFaker : Faker<Product>
{
    public ProductFaker()
    {
        RuleFor(p=>p.Id, p => p.IndexFaker);
        RuleFor(p=>p.Name, f => f.Commerce.ProductName());
        RuleFor(p=>p.Color, f=>f.Commerce.Color());
    }
}