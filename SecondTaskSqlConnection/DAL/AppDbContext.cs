using Microsoft.EntityFrameworkCore;

namespace SecondTaskSqlConnection.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

    }
}
