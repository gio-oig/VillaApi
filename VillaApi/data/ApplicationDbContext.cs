using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VillaApi.models;

namespace VillaApi.data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
            new Villa
            {
                Id = 1,
                Name = "Roial Villa",
                Details = "details test",
                ImageUrl = "",
                Occupancy = 5,
                Rate = 200,
                Sqft = 550,
                Amenity = "",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 2,
                Name = "Luxury Villa",
                Details = "details test",
                ImageUrl = "",
                Occupancy = 8,
                Rate = 500,
                Sqft = 1200,
                Amenity = "",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 3,
                Name = "Beachfront Villa",
                Details = "details test",
                ImageUrl = "",
                Occupancy = 6,
                Rate = 300,
                Sqft = 800,
                Amenity = "",
                CreatedDate = DateTime.Now
            },
            new Villa
            {
                Id = 4,
                Name = "Private Villa",
                Details = "details test",
                ImageUrl = "",
                Occupancy = 4,
                Rate = 150,
                Sqft = 450,
                Amenity = "",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 5,
                Name = "Honeymoon Villa",
                Details = "details test",
                ImageUrl = "",
                Occupancy = 2,
                Rate = 100,
                Sqft = 350,
                Amenity = "",
                CreatedDate = DateTime.Now,
            },
            new Villa
            {
                Id = 6,
                Name = "Mountain View Villa",
                Details = "details test",
                ImageUrl = "",
                Occupancy = 7,
                Rate = 400,
                Sqft = 1000,
                Amenity = "",
                CreatedDate = DateTime.Now
            }
           );
        }
    }
}

