﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPILab.Data;

#nullable disable

namespace WebAPILab.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220519002217_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPILab.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Horror",
                            Title = "Halloween",
                            Year = 1978
                        },
                        new
                        {
                            Id = 2,
                            Category = "Drama",
                            Title = "Mr. Brooks",
                            Year = 2007
                        },
                        new
                        {
                            Id = 3,
                            Category = "Comedy",
                            Title = "The Princess Bride",
                            Year = 1987
                        },
                        new
                        {
                            Id = 4,
                            Category = "Horror",
                            Title = "Alien",
                            Year = 1979
                        },
                        new
                        {
                            Id = 5,
                            Category = "Comedy",
                            Title = "Dr. Strangelove",
                            Year = 1964
                        },
                        new
                        {
                            Id = 6,
                            Category = "Drama",
                            Title = "Pig",
                            Year = 2021
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
