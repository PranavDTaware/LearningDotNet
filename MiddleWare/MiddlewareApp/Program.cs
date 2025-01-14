var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use();

app.Run(async context =>
{
    await context.Response.WriteAsync("End of Middleware Pipeline.");
});