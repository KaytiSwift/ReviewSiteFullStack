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
                },

                new Review()
                {
                    Id = 4,
                    Title = "Iron Man",
                    ImageURL = "/images/IronMan.jpg",
                    CategoryId = 3,
                    Content = "This movie is when the Marvel Cinematic Universe really started to come alive for me.",
                    AltPicText = "Iron Man"
                },

                new Review()
                {
                    Id = 5,
                    Title = "The Holiday Calendar",
                    ImageURL = "/images/HolidayCalendar.jpg",
                    CategoryId = 4,
                    Content = "This movie is your typical cliche romantic comedy but that didn't stop me from loving it.",
                    AltPicText = "Holiday Calendar"
                },

                new Review()
                {
                    Id = 6,
                    Title = "Eternal Sunshine of the Spotless Mind",
                    ImageURL = "/images/EternalSunshine.jpg",
                    CategoryId = 4,
                    Content = "One of the best movies I've ever seen! It is not a typical cliche romantic comedy and it has the best performance of Jim Carey's career.",
                    AltPicText = "Eternal Sunshine"
                },

                new Review()
                {
                    Id = 7,
                    Title = "Avatar",
                    ImageURL = "/images/Avatar.jpg",
                    CategoryId = 2,
                    Content = "This is a great movie with something for everyone.",
                    AltPicText = "Avatar"
                },

                new Review()
                {
                    Id = 8,
                    Title = "Arrival",
                    ImageURL = "/images/Arrival.jpg",
                    CategoryId = 1,
                    Content = "While many people raved about how awesome this movie was and how great the ending was, I have to say that I was disappointed because I saw the ending coming from a mile away.",
                    AltPicText = "Arrival"
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
                },
                new Category()
                {
                    Id = 4,
                    Name = "RomCom"
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
