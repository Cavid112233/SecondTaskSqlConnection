using SecondTaskSqlConnection.DAL;

namespace SecondTaskSqlConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            app.UseStaticFiles();
            app.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}/{id?}"

                );
            app.Run();
        }
    }
}
