using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;

public class DbCustomerRepository : ICustomerRepository
{
    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> Get(string name)
    {
        throw new NotImplementedException();
    }

    public void Add(Customer entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer entity)
    {
        throw new NotImplementedException();
    }
}
