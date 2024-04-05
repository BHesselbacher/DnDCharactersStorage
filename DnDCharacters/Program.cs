using DnDCharacters.Database;
using DnDCharacters.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DnDCharactersEntityFrameworkCoreDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DnDCharactersEntityFrameworkCoreLocalConnection")));

builder.Services.AddScoped<IDnDCharacterRepository, DnDCharactersEntityFrameworkCoreDbContext>();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
