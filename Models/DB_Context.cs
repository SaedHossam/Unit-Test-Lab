using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var role = new Roles()
            {
                Id = 1,
                Role = "Admin"
            };

            var user = new User()
            {
                Id = 1,
                Username = "admin",
                Password = "1234"
            };
            var userRole = new UserRole() { 
                Id = 1,
                UserId = 1,
                RoleId = 1
            };
            modelBuilder.Entity<Roles>().HasData(role);
            modelBuilder.Entity<User>().HasData(user);
            modelBuilder.Entity<UserRole>().HasData(userRole);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
