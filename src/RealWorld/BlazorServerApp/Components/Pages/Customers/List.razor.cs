using BlazorServerApp.Abstractions;
using BlazorServerApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.Components.Pages.Customers;

public partial class List
{
    private List<Customer> customers = new List<Customer>();

    [Inject]
    public ICustomerRepository repository { get; set; }

    protected override void OnInitialized()
    {
        customers = repository.GetAll();
    }

    private void Search(string searchText)
    {
        Console.WriteLine($"Searching {searchText}...");

        customers = repository.Get(searchText);
    }
}
