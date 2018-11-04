﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewApp.Models;

namespace ReviewApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20181104014853_AddSeedDataTagsAndReviewTags")]
    partial class AddSeedDataTagsAndReviewTags
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Name = "Sci-Fi" },
                        new { Id = 2, Name = "Fantasy" },
                        new { Id = 3, Name = "Action" },
                        new { Id = 4, Name = "RomCom" }
                    );
                });

            modelBuilder.Entity("ReviewApp.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltPicText");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<string>("ImageURL");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { Id = 1, AltPicText = "Venom", CategoryId = 3, Content = "The critics said this movie sucked! I haven't seen it yet but Neko said it was awesome! I guess I need to go see it myself.", ImageURL = "/images/Venom.jpg", Title = "Venom" },
                        new { Id = 2, AltPicText = "Harry Potter", CategoryId = 2, Content = "Best movie EVER!!! Based on the best book series ever! I love this movie. Go watch it if you haven't.", ImageURL = "/images/HarryPotter.jpg", Title = "Harry Potter and the Philosopher's Stone" },
                        new { Id = 3, AltPicText = "Guardians", CategoryId = 1, Content = "Hilarious! A must see movie! High quality writing just like every other MCU movie. If they don't make a third one, my heart will break.", ImageURL = "/images/Guardians.jpg", Title = "Guardians of the Galaxy" },
                        new { Id = 4, AltPicText = "Iron Man", CategoryId = 3, Content = "This movie is when the Marvel Cinematic Universe really started to come alive for me.", ImageURL = "/images/IronMan.jpg", Title = "Iron Man" },
                        new { Id = 5, AltPicText = "Holiday Calendar", CategoryId = 4, Content = "This movie is your typical cliche romantic comedy but that didn't stop me from loving it.", ImageURL = "/images/HolidayCalendar.jpg", Title = "The Holiday Calendar" },
                        new { Id = 6, AltPicText = "Eternal Sunshine", CategoryId = 4, Content = "One of the best movies I've ever seen! It is not a typical cliche romantic comedy and it has the best performance of Jim Carey's career.", ImageURL = "/images/EternalSunshine.jpg", Title = "Eternal Sunshine of the Spotless Mind" },
                        new { Id = 7, AltPicText = "Avatar", CategoryId = 2, Content = "This is a great movie with something for everyone.", ImageURL = "/images/Avatar.jpg", Title = "Avatar" },
                        new { Id = 8, AltPicText = "Arrival", CategoryId = 1, Content = "While many people raved about how awesome this movie was and how great the ending was, I have to say that I was disappointed because I saw the ending coming from a mile away.", ImageURL = "/images/Arrival.jpg", Title = "Arrival" }
                    );
                });

            modelBuilder.Entity("ReviewApp.Models.ReviewTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReviewId");

                    b.Property<int>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("ReviewId");

                    b.HasIndex("TagId");

                    b.ToTable("ReviewTag");

                    b.HasData(
                        new { Id = 1, ReviewId = 1, TagId = 5 },
                        new { Id = 2, ReviewId = 1, TagId = 7 },
                        new { Id = 3, ReviewId = 1, TagId = 8 },
                        new { Id = 4, ReviewId = 2, TagId = 3 },
                        new { Id = 5, ReviewId = 2, TagId = 4 },
                        new { Id = 6, ReviewId = 2, TagId = 7 },
                        new { Id = 7, ReviewId = 3, TagId = 2 },
                        new { Id = 8, ReviewId = 3, TagId = 4 },
                        new { Id = 9, ReviewId = 3, TagId = 5 },
                        new { Id = 10, ReviewId = 3, TagId = 7 },
                        new { Id = 11, ReviewId = 3, TagId = 8 },
                        new { Id = 12, ReviewId = 4, TagId = 2 },
                        new { Id = 13, ReviewId = 4, TagId = 4 },
                        new { Id = 14, ReviewId = 4, TagId = 5 },
                        new { Id = 15, ReviewId = 4, TagId = 7 },
                        new { Id = 16, ReviewId = 4, TagId = 8 },
                        new { Id = 17, ReviewId = 5, TagId = 1 },
                        new { Id = 18, ReviewId = 5, TagId = 6 },
                        new { Id = 19, ReviewId = 5, TagId = 7 },
                        new { Id = 20, ReviewId = 6, TagId = 4 },
                        new { Id = 21, ReviewId = 6, TagId = 6 },
                        new { Id = 22, ReviewId = 6, TagId = 7 },
                        new { Id = 23, ReviewId = 7, TagId = 4 },
                        new { Id = 24, ReviewId = 7, TagId = 6 },
                        new { Id = 25, ReviewId = 7, TagId = 7 },
                        new { Id = 26, ReviewId = 7, TagId = 8 },
                        new { Id = 27, ReviewId = 8, TagId = 1 },
                        new { Id = 28, ReviewId = 8, TagId = 3 },
                        new { Id = 29, ReviewId = 8, TagId = 6 },
                        new { Id = 30, ReviewId = 8, TagId = 7 }
                    );
                });

            modelBuilder.Entity("ReviewApp.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new { Id = 1, Text = "#femaleLead" },
                        new { Id = 2, Text = "#superHeroes" },
                        new { Id = 3, Text = "#basedOnABook" },
                        new { Id = 4, Text = "#extraAwesome" },
                        new { Id = 5, Text = "#comics" },
                        new { Id = 6, Text = "#romance" },
                        new { Id = 7, Text = "#well-acted" },
                        new { Id = 8, Text = "#violence" }
                    );
                });

            modelBuilder.Entity("ReviewApp.Models.Review", b =>
                {
                    b.HasOne("ReviewApp.Models.Category", "Category")
                        .WithMany("Reviews")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ReviewApp.Models.ReviewTag", b =>
                {
                    b.HasOne("ReviewApp.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ReviewApp.Models.Tag", "Tag")
                        .WithMany("ReviewTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
