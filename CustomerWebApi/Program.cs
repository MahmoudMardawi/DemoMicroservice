using CustomerWebApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var dbHost = "localhost";
var dbName = "dms_customer";
var dbPassword = "Ma@091847";
var connectionstring = $"Data Source ={dbHost}; Initial Catalog ={dbName}; User ID = sa; Password ={dbPassword}";
builder.Services.AddDbContext<CustomerDbContext>(opt => opt.UseSqlServer(connectionstring));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
