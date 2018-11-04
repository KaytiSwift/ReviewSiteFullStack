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
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ReviewTag> ReviewTags { get; set; }

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

            modelBuilder.Entity<Tag>().HasData(
                new Tag() { Id = 1, Text = "#femaleLead" },
                new Tag() { Id = 2, Text = "#superHeroes"},
                new Tag() { Id = 3, Text = "#basedOnABook"},
                new Tag() { Id = 4, Text = "#extraAwesome"},
                new Tag() { Id = 5, Text = "#comics" },
                new Tag() { Id = 6, Text = "#romance" },
                new Tag() { Id = 7, Text = "#well-acted" },
                new Tag() { Id = 8, Text = "#violence" }
                );

            modelBuilder.Entity<ReviewTag>().HasData(
                new ReviewTag() { Id = 1, ReviewId = 1, TagId = 5},
                new ReviewTag() { Id = 2, ReviewId = 1, TagId = 7 },
                new ReviewTag() { Id = 3, ReviewId = 1, TagId = 8 },
                new ReviewTag() { Id = 4, ReviewId = 2, TagId = 3 },
                new ReviewTag() { Id = 5, ReviewId = 2, TagId = 4 },
                new ReviewTag() { Id = 6, ReviewId = 2, TagId = 7 },
                new ReviewTag() { Id = 7, ReviewId = 3, TagId = 2 },
                new ReviewTag() { Id = 8, ReviewId = 3, TagId = 4 },
                new ReviewTag() { Id = 9, ReviewId = 3, TagId = 5 },
                new ReviewTag() { Id = 10, ReviewId = 3, TagId = 7 },
                new ReviewTag() { Id = 11, ReviewId = 3, TagId = 8 },
                new ReviewTag() { Id = 12, ReviewId = 4, TagId = 2 },
                new ReviewTag() { Id = 13, ReviewId = 4, TagId = 4 },
                new ReviewTag() { Id = 14, ReviewId = 4, TagId = 5 },
                new ReviewTag() { Id = 15, ReviewId = 4, TagId = 7 },
                new ReviewTag() { Id = 16, ReviewId = 4, TagId = 8 },
                new ReviewTag() { Id = 17, ReviewId = 5, TagId = 1 },
                new ReviewTag() { Id = 18, ReviewId = 5, TagId = 6 },
                new ReviewTag() { Id = 19, ReviewId = 5, TagId = 7 },
                new ReviewTag() { Id = 20, ReviewId = 6, TagId = 4 },
                new ReviewTag() { Id = 21, ReviewId = 6, TagId = 6 },
                new ReviewTag() { Id = 22, ReviewId = 6, TagId = 7 },
                new ReviewTag() { Id = 23, ReviewId = 7, TagId = 4 },
                new ReviewTag() { Id = 24, ReviewId = 7, TagId = 6 },
                new ReviewTag() { Id = 25, ReviewId = 7, TagId = 7 },
                new ReviewTag() { Id = 26, ReviewId = 7, TagId = 8 },
                new ReviewTag() { Id = 27, ReviewId = 8, TagId = 1 },
                new ReviewTag() { Id = 28, ReviewId = 8, TagId = 3 },
                new ReviewTag() { Id = 29, ReviewId = 8, TagId = 6 },
                new ReviewTag() { Id = 30, ReviewId = 8, TagId = 7 }
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
