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
    [Migration("20181022194055_AddedSeedDataCategories")]
    partial class AddedSeedDataCategories
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
                        new { Id = 3, Name = "Action" }
                    );
                });

            modelBuilder.Entity("ReviewApp.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltPicText");

                    b.Property<string>("Content");

                    b.Property<string>("ImageURL");

                    b.Property<string>("ReviewCategory");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Reviews");

                    b.HasData(
                        new { Id = 1, AltPicText = "Venom", Content = "The critics said this movie sucked! I haven't seen it yet but Neko said it was awesome! I guess I need to go see it myself.", ImageURL = "/images/Venom.jpg", ReviewCategory = "Action", Title = "Venom" },
                        new { Id = 2, AltPicText = "Harry Potter", Content = "Best movie EVER!!! Based on the best book series ever! I love this movie. Go watch it if you haven't.", ImageURL = "/images/HarryPotter.jpg", ReviewCategory = "Fantasy", Title = "Harry Potter and the Philosopher's Stone" },
                        new { Id = 3, AltPicText = "Guardians", Content = "Hilarious! A must see movie! High quality writing just like every other MCU movie. If they don't make a third one, my heart will break.", ImageURL = "/images/Guardians.jpg", ReviewCategory = "Sci-Fi", Title = "Guardians of the Galaxy" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
