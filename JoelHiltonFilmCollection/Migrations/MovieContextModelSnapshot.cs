﻿// <auto-generated />
using JoelHiltonFilmCollection.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JoelHiltonFilmCollection.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("JoelHiltonFilmCollection.Models.FormResponse", b =>
                {
                    b.Property<int>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("FormId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            FormId = 1,
                            Category = "Science Fiction",
                            Director = "George Lucas",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "A New Hope",
                            Year = 1978
                        },
                        new
                        {
                            FormId = 2,
                            Category = "Science Fiction",
                            Director = "Irvin Kershner",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "The Empire Strikes Back",
                            Year = 1980
                        },
                        new
                        {
                            FormId = 3,
                            Category = "Science Fiction",
                            Director = "Richard Marquand",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Return of the Jedi",
                            Year = 1983
                        });
                });
#pragma warning restore 612, 618
        }
    }
}