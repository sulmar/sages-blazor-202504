using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;

public class FakeCustomerRepository : ICustomerRepository
{
    private Dictionary<int, Customer> _customers = new Dictionary<int, Customer>();

    public FakeCustomerRepository()
    {
        var customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Customer #1", City = "Warszawa" } ,
            new Customer { Id = 2, Name = "Customer #2", City = "Kraków" } ,
            new Customer { Id = 3, Name = "Customer #3", City = "Maszkowice" },
            new Customer { Id = 4, Name = "Customer #4", City = "Poznań" } ,
            new Customer { Id = 5, Name = "Customer #5", City = "Częstochowa" } ,
            new Customer { Id = 6, Name = "Customer #6", City = "Warszawa" } 
        };

        _customers = customers.ToDictionary(p=>p.Id);
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