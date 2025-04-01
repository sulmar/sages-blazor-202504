using BlazorServerApp.Abstractions;
using BlazorServerApp.Components;
using BlazorServerApp.Fakers;
using BlazorServerApp.Infrastructures;
using BlazorServerApp.Models;
using Bogus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<ICustomerRepository, FakeCustomerRepository>();
builder.Services.AddSingleton<Faker<Customer>, CustomerFaker>();
builder.Services.AddSingleton<List<Customer>>(sp =>
{
    var faker = sp.GetRequiredService<Faker<Customer>>();

    var customers = faker.Generate(10);

    return customers;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
