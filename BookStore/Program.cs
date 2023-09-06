using BookStore.Data;
using BookStore.Interfaces;
using BookStore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Linking DbContext in mysql
builder.Services.AddDbContext<BookStoreDbContext>( options=>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyString"));
}
);

//Letting main method know of creation of repo and interfaces
builder.Services.AddScoped<IUserRepository, UserRepository > ();
builder.Services.AddControllers();
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
