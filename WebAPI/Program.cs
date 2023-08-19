using WebAPI.Models; // Using the models
using Microsoft.EntityFrameworkCore; // Reference the models that i am using

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Dependency injection, therefore we need to reference the connection string with the dbcontext
var connectionString = builder.Configuration.GetConnectionString("EcoPowerSolutionsDB");  
builder.Services.AddDbContext<EcoPowerSolutionsDBContext>(options => options.UseSqlServer(connectionString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
