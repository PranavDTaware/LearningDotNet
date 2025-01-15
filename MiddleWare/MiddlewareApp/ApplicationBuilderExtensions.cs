

namespace middlewareapp
{
    public static class ApplicationbuilderExtensions
    {
        public static void UseFirstMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("First ");
                await next();
            });
        }
        public static void UseSecondMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Second ");
                await next();
            });
        }
        public static void UseLastMiddleware(this IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Last ");
            });
        }
    }
}