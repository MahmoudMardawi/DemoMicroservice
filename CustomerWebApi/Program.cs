using CustomerWebApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

 
builder.Services.AddDbContext<CustomerDbContext>(opt => opt.UseSqlServer("Data Source=LAPTOP-GINQ8KH0;Initial Catalog=Customer;User ID=sa;Password=Ma@091847;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
