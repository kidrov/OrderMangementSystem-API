using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OrderManagementSystem.Models;

namespace OrderManagementSystem
{
    public class KeepDbContext : DbContext
    {
        public KeepDbContext(DbContextOptions<KeepDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }


    }
}
