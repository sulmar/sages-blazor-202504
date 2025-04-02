using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;


public class FakeCustomerRepository : ICustomerRepository
{
    private Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

    public FakeCustomerRepository(List<Customer> customers)
    {
        _customers = customers.ToDictionary(p => p.Id);
    }

    public List<Customer> GetAll()
    {
        return _customers.Values.ToList();
    }

    public Customer Get(int id)
    {
        return _customers[id];
    }

}
