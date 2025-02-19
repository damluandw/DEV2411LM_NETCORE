using Microsoft.EntityFrameworkCore;
using NETCORE_Lesson05_CodeFirst.Models.DataModels;

namespace NETCORE_Lesson05_CodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddMvc();
            var connectString = builder.Configuration.GetConnectionString("DBConnect");
            builder.Services.AddDbContext<BookManageContext>(op => op.UseSqlServer(connectString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<BookManageContext>(op => op.UseSqlServer("DBConnect"));
        }
    }
}
