namespace BlazorServerApp.Models;

public class User : BaseEntity
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
}
