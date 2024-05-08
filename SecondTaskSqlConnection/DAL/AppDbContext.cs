using Microsoft.EntityFrameworkCore;
using SecondTaskSqlConnection.Models;

namespace SecondTaskSqlConnection.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OrganicVegetable> OrganicVegetables { get; set; }
        public DbSet<ChooseUs> ChooseUses { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
    }
}
