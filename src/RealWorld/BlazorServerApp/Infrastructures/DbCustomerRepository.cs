using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;

public class DbCustomerRepository : ICustomerRepository
{
    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }
}
