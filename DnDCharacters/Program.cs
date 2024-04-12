using DnDCharacters.Database;
using DnDCharacters.Models;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddMySqlDataSource(builder.Configuration.GetConnectionString("Default"));

builder.Services.AddScoped<IDnDCharacterRepository, DnDCharactersEntityFrameworkCoreDbContext>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
