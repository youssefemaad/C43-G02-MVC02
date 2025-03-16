using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Assignment_1.Models;
using Assignment_1.Controllers;


namespace Assignment_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var builder = WebApplication.CreateBuilder(args);
            // builder.Services.AddControllers();
            // var app = builder.Build();
            // app.UseRouting();
            // app.MapGet("/", () => "Hello, World!");
            // app.MapGet("/{name}", async context =>
            // {
            //     var name = context.Request.RouteValues["name"];
            //     await context.Response.WriteAsync($"Hello, {name}!");
            // });

            // app.MapControllerRoute(
            //     name: "default",
            //     pattern: "{controller}/{action}/{id?}",
            //     constraints: new {id = new IntRouteConstraint() } // or new {id = @"\d{2}"}
            // );

            // app.Run();

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
            );

            app.Run();

        }
    }
}