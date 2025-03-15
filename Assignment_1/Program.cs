namespace Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.UseRouting();
            app.MapGet("/", () => "Hello, World!");
            app.MapGet("/{name}", async context =>
            {
                var name = context.Request.RouteValues["name"];
                await context.Response.WriteAsync($"Hello, {name}!");
            });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id}");

            app.Run();

        }
    }
}