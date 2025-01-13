var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/aboutus", () => "Welcome to transflower!");
app.MapGet("/contact", () => "Welcome to transflower!");

app.UseRoutiong();
app.MapControllerRoute(
    name: "default",
    pattern: "{}"
    )
)

app.Run();
