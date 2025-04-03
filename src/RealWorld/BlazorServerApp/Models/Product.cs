namespace BlazorServerApp.Models;

public partial class Product : BaseEntity
{
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }

    public decimal CalculateDiscount()
    {
        return Price;
    }
}