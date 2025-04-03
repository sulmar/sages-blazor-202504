using BlazorServerApp.Abstractions;
using BlazorServerApp.Components;
using BlazorServerApp.Fakers;
using BlazorServerApp.Hubs;
using BlazorServerApp.Infrastructures;
using BlazorServerApp.Models;
using BlazorServerApp.Services;
using Bogus;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// builder.Services.AddScoped<HttpClient>(sp => new HttpClient {  BaseAddress = new Uri("https://jsonplaceholder.typicode.com") });

// Named Clients
// builder.Services.AddHttpClient("jsonplaceholder", client => client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"));
builder.Services.AddHttpClient("nbp", client => client.BaseAddress = new Uri("https://api.nbp.pl"));

// Typed Clients
builder.Services.AddHttpClient<JsonPlaceholderUserService>(client => client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com"));


builder.Services.AddTransient<ICustomerRepository, FakeCustomerRepository>();
builder.Services.AddSingleton<Faker<Customer>, CustomerFaker>();
builder.Services.AddSingleton<List<Customer>>(sp =>
{
    var faker = sp.GetRequiredService<Faker<Customer>>();

    var customers = faker.Generate(10);

    return customers;
});

builder.Services.AddTransient<IProductRepository, FakeProductRepository>();
builder.Services.AddSingleton<Faker<Product>, ProductFaker>();
builder.Services.AddSingleton<List<Product>>(sp =>
{

    var faker = sp.GetRequiredService<Faker<Product>>();

    var products = faker.Generate(10);

    return products;
});

builder.Services.AddSignalR();

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

app.MapHub<DashboardHub>("/signalr/dashboard");

app.Run();
