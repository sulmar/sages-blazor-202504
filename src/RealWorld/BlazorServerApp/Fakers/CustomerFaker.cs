using BlazorServerApp.Models;
using Bogus;

namespace BlazorServerApp.Fakers;

// dotnet add package Bogus
public class CustomerFaker : Faker<Customer>
{
    public CustomerFaker()
    {
        RuleFor(p => p.Id, p => p.IndexFaker);
        RuleFor(p => p.Name, p => p.Company.CompanyName());
        RuleFor(p => p.City, p => p.Address.City());
    }
}
