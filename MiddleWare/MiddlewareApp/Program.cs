using middlewareapp;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");



/*app.Run(async context =>
{
    await context.Response.WriteAsync("Hello World");

});*/

/*app.Use(async (context, next) =>
{
    //intercept the request
    //based on path send different response

    if (context.Request.Path == "/hello")
    {
        await context.Response.WriteAsync("Hello World!");
    }
    else if (context.Request.Path == "/welcome")
    {
        await context.Response.WriteAsync("Welcome to Transflowr!");
    }
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Second Middleware Response.... ");
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Third Middleware Response......");
    await next();
});

app.Run(async context =>
{
    await context.Response.WriteAsync("End of Middleware Pipeline.");
});*/

/*app.UseFirstMiddleware(); //custom middleware
app.UseSecondMiddleware();
app.UseLastMiddleware();*/
// app.UseWelcomePage();   //inbuilt middleware
app.UseStaticFiles();   //inbuilt middleware

app.Run();