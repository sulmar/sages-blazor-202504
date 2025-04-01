using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;

namespace BlazorServerApp.Infrastructures;

public class FakeCustomerRepository : ICustomerRepository
{
    private List<Customer> customers = new List<Customer>();

    public FakeCustomerRepository()
    {
        customers.Add(new Customer { Id = 1, Name = "Customer #1", City = "Warszawa" });
        customers.Add(new Customer { Id = 2, Name = "Customer #2", City = "Kraków" });
        customers.Add(new Customer { Id = 3, Name = "Customer #3", City = "Maszkowice" });
        customers.Add(new Customer { Id = 4, Name = "Customer #4", City = "Poznań" });
        customers.Add(new Customer { Id = 4, Name = "Customer #5", City = "Częstochowa" });
        customers.Add(new Customer { Id = 1, Name = "Customer #6", City = "Warszawa" });
    }


    public List<Customer> GetAll()
    {
        return customers;
    }
        
}