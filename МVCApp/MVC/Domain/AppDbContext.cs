using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ManagerMVC.Domain.Entities;
using System;

namespace ManagerMVC.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ServiceItem> ServiceItems { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "43546e06-8719-4ad8-b88a-f271ae9d6eba",
                Name = "manager",
                NormalizedName = "MANAGER"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "2b62472e-4f66-49fa-a20f-e7685b9565d7",
                UserName = "manager",
                NormalizedUserName = "MANAGER",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "manager"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "43546e06-8719-4ad8-b88a-f271ae9d6eba",
                UserId = "2b62472e-4f66-49fa-a20f-e7685b9565d7"
            });

            modelBuilder.Entity<ServiceItem>().HasData(new ServiceItem
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                TitleImagePath = "",
                Title = "Послуга1",
                Subtitle = "короткий опис послуги 1",
                Text = "some text",
                Price = 100
            });

            modelBuilder.Entity<ServiceItem>().HasData(new ServiceItem
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                TitleImagePath = "",
                Title = "Послуга1",
                Subtitle = "короткий опис послуги 2",
                Text = "some text",
                Price = 150
            });

            modelBuilder.Entity<ServiceItem>().HasData(new ServiceItem
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                TitleImagePath = "",
                Title = "Послуга 3",
                Subtitle = "короткий опис посллуги 3",
                Text = "some text",
                Price = 200
            });
           
        }
    }
}
