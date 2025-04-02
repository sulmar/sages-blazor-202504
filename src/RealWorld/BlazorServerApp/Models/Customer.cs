namespace BlazorServerApp.Models;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
}
