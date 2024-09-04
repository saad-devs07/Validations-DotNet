using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Validations.Data;
namespace Validations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<ValidationsContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ValidationsContext") ?? throw new InvalidOperationException("Connection string 'ValidationsContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Students}/{action=Index}/{id?}");

            app.Run();
        }
    }
}