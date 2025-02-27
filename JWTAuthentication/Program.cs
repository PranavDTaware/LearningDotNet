using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using WebApi.Helpers;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// configure DI for application services
builder.Services.AddScoped<IUserService, UserService>();

app.UseRouting();
 // Custom jwt auth middleware
app.UseMiddleware<JwtMiddleware>();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
app.Run();