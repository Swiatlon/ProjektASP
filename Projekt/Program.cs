using Projekt.Models.Products;
using Projekt.Models.Producer;

namespace Projekt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<Data.AppDbContext>();
            builder.Services.AddTransient<IProductService, ProductService>();
            builder.Services.AddTransient<IProducerService, ProducerService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/Home/Error";
                    await next();
                }
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "error",
                pattern: "Error/{statusCode}",
                defaults: new { controller = "Error", action = "Index" }
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.UseStatusCodePagesWithReExecute("/Error/{0}");


            app.Run();
        }
    }
}
