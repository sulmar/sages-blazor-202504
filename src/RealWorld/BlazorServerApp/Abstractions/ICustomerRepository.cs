using BlazorServerApp.Components.Pages;
using BlazorServerApp.Models;

namespace BlazorServerApp.Abstractions;


public interface ICustomerRepository : IEntityRepository<Customer>
{
}






#region Interfejsy

public interface IWplatomat
{
    void Wplata(string account, decimal amount);
}

public interface IWyplatomat
{
    void Wyplata(string account, decimal amount);
}

public interface IBankomat : IWyplatomat, IWplatomat  // Rozszerzenie interfejsu
{
    decimal PobierzSaldo(string account);  
}

public class MyBankomat : IBankomat
{
    public decimal PobierzSaldo(string account)
    {
        throw new NotImplementedException();
    }

    public void Wplata(string account, decimal amount)
    {
        throw new NotImplementedException();
    }

    public void Wyplata(string account, decimal amount)
    {
        throw new NotImplementedException();
    }
}


#endregion