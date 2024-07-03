using Microsoft.EntityFrameworkCore;
using MiniMicroProject.API.Models;
using System;

namespace MiniMicroProject.API.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
