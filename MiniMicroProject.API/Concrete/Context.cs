using Microsoft.EntityFrameworkCore;
using MiniMicroProject.API.Models;

namespace MiniMicroProject.API.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Kadir;Initial Catalog=ApiDb;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
