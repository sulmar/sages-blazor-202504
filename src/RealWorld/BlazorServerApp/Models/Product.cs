namespace BlazorServerApp.Models;

public class Product : BaseEntity
{
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
}