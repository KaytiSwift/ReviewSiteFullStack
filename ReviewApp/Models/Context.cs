using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewApp.Models
{
    public class Context : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(
                
                new Review()
                {
                    Id = 1,
                    Title = "Venom",
                    ImageURL = "/images/Venom.jpg",
                    CategoryId = 3,
                    Content = "The critics said this movie sucked! I haven't seen it yet but Neko said it was awesome! I guess I need to go see it myself.",
                    AltPicText = "Venom"
                },
                                
                new Review()
                {
                    Id = 2,
                    Title = "Harry Potter and the Philosopher's Stone",
                    ImageURL = "/images/HarryPotter.jpg",
                    CategoryId = 2,
                    Content = "Best movie EVER!!! Based on the best book series ever! I love this movie. Go watch it if you haven't.",
                    AltPicText = "Harry Potter"
                },

                new Review()
                {
                    Id = 3,
                    Title = "Guardians of the Galaxy",
                    ImageURL = "/images/Guardians.jpg",
                    CategoryId = 1,
                    Content = "Hilarious! A must see movie! High quality writing just like every other MCU movie. If they don't make a third one, my heart will break.",
                    AltPicText = "Guardians"
                }                
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Sci-Fi"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Fantasy"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Action"
                }
                );
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReviewsKS;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
