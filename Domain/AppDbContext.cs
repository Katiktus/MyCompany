using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using System;

namespace MyCompany.Domain
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "d6812dc5-6576-481a-848c-33f7baa631f7",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "katpog2001@gmail.com",
                NormalizedEmail = "KATPOG2001@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "c7c5f406-024f-4176-8ed0-6cb0e017d7a2",
                UserId = "d6812dc5-6576-481a-848c-33f7baa631f7"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("31c516be-6462-4f5a-8fcd-cec0161f0abf"),
                CodeWord = "PageIndex",
                Title="Главная"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("94ac87b3-7cee-4fe5-837d-cc396309b97a"),
                CodeWord = "PageServices",
                Title = "Наши услуги"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("6b5cf1f2-a258-413d-b0e1-2a2543d166ca"),
                CodeWord = "PageContacts",
                Title = "Контакты"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("58b650cb-4d3d-4603-bc1f-b1a91bc08be4"),
                CodeWord = "PageNews",
                Title = "Новости"
            });
        }
    }
}
