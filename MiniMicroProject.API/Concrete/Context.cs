using Microsoft.EntityFrameworkCore;
using MiniMicroProject.API.Models;
using System;

namespace MiniMicroProject.API.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            //Database path redirected to program.cs//
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
