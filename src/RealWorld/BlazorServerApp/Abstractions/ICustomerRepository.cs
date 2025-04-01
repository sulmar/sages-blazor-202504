using BlazorServerApp.Components.Pages;
using BlazorServerApp.Models;

namespace BlazorServerApp.Abstractions;

public interface ICustomerRepository
{
    List<Customer> GetAll();
}
