In ASP.NET Core, the Program.cs file plays a crucial role in configuring services and middleware for your application. Starting with ASP.NET Core 6 and beyond, a simplified model was introduced where both the setup of services (DI container) and middleware (HTTP request pipeline) are configured in a streamlined Program.cs file.

Here's a breakdown of how you configure services and middleware using the builder object in Program.cs.

Key Sections of Program.cs in ASP.NET Core

1. Setting up Services: This is where you configure the services required by your application using builder.Services. These services are registered in the Dependency Injection (DI) container.


2. Configuring Middleware: This is where you set up the HTTP request pipeline using builder.Build() and define the middleware that will handle HTTP requests.



Full Example of Program.cs in ASP.NET Core 6+:

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 1. Registering Services
// Registering services in the DI container.
builder.Services.AddRazorPages();  // Example service (for Razor Pages)
builder.Services.AddControllers(); // Example service (for MVC Controllers)
builder.Services.AddSingleton<IMyService, MyService>(); // Register a custom service

// You can also configure database contexts, authentication, logging, etc.
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Build the Application
var app = builder.Build();

// 3. Configure Middleware
// Set up the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();  // In Development, show detailed error pages
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Custom error handling for production
    app.UseHsts(); // HTTP Strict Transport Security
}

// Default middleware to serve static files (e.g., wwwroot folder).
app.UseStaticFiles(); 

// Routing setup
app.UseRouting();

// Use authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

// Map controllers and pages
app.MapControllers(); // Map MVC Controllers
app.MapRazorPages(); // Map Razor Pages

// 4. Run the application
app.Run();

Breakdown of Configuration

1. Setting up Services

In the first part of Program.cs, you register services using builder.Services. This includes things like adding controllers, Razor Pages, Entity Framework Core, or any other services your app needs.

builder.Services.AddRazorPages();  // Register Razor Pages service
builder.Services.AddControllers(); // Register Controllers service
builder.Services.AddSingleton<IMyService, MyService>(); // Register custom service

You can also register more advanced services, such as:

Database Context with AddDbContext<T>.

Authentication and Authorization services using AddAuthentication, AddAuthorization.

Logging services, etc.


For example, adding Entity Framework Core:

builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

2. Building the Application

Once the services are registered, you call builder.Build() to create an instance of WebApplication (app), which will later be used to configure the request pipeline.

var app = builder.Build();

3. Configuring Middleware

Here, you configure the HTTP request pipeline, including middleware components such as error handling, authentication, routing, and static file serving.

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();  // In Development, show detailed error pages
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Custom error handling for production
    app.UseHsts(); // HTTP Strict Transport Security
}

Static Files: This middleware serves static files (e.g., from the wwwroot directory).


app.UseStaticFiles();

Routing: The app.UseRouting() method enables routing, allowing the app to map requests to the appropriate controllers or pages.


app.UseRouting();

Authentication & Authorization: If your app has authentication or authorization, you'll configure those middlewares as well.


app.UseAuthentication();
app.UseAuthorization();

Endpoint Mapping: This is where the app maps the controllers or Razor Pages to endpoints.


app.MapControllers(); // Maps API controller routes
app.MapRazorPages();  // Maps Razor Page routes

4. Running the Application

Finally, the app.Run() method starts the application.

app.Run();

Common Configurations in Program.cs

Custom Middleware: If you have your own middleware, you can add it to the pipeline using app.UseMiddleware<T>():

app.UseMiddleware<CustomMiddleware>();

Swagger for API Documentation: If you're building an API and want to add Swagger for documentation:

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In the middleware configuration
app.UseSwagger();
app.UseSwaggerUI();

Session and Cookies: For session management, you can configure the middleware and services for cookies or sessions:

builder.Services.AddSession();
app.UseSession();


Conclusion

In ASP.NET Core, the Program.cs file is where you configure both services and middleware. Services are registered in the DI container using builder.Services, and middleware is added to the HTTP request pipeline using methods on the app object after calling builder.Build(). This model provides a clear and concise way to configure your application in a modern, streamlined approach.