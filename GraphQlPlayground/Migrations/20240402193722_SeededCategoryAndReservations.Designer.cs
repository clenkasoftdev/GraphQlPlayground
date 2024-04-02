﻿// <auto-generated />
using System;
using GraphQlPlayground.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQlPlayground.Migrations
{
    [DbContext(typeof(GraphQlPlaygroundDbContext))]
    [Migration("20240402193722_SeededCategoryAndReservations")]
    partial class SeededCategoryAndReservations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraphQlPlayground.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "https://www.google.com",
                            Name = "Fast Food"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://www.google.com",
                            Name = "Italian"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "https://www.google.com",
                            Name = "Mexican"
                        });
                });

            modelBuilder.Entity("GraphQlPlayground.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Cheese Pizza",
                            ImageUrl = "https://www.google.com",
                            Name = "Pizza",
                            Price = 10.0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Cheese Burger",
                            ImageUrl = "https://www.google.com",
                            Name = "Burger",
                            Price = 5.0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "Cheese Pasta",
                            ImageUrl = "https://www.google.com",
                            Name = "Pasta",
                            Price = 8.0
                        });
                });

            modelBuilder.Entity("GraphQlPlayground.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpecialRequest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerName = "John Doe",
                            Email = "john.doe@test.com",
                            PartySize = 4,
                            PhoneNumber = "1234567890",
                            ReservationDate = new DateTime(2024, 6, 20, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            SpecialRequest = "Near the window"
                        },
                        new
                        {
                            Id = 2,
                            CustomerName = "Max Mann",
                            Email = "max1@mann.com",
                            PartySize = 30,
                            PhoneNumber = "02222333",
                            ReservationDate = new DateTime(2024, 7, 10, 18, 0, 0, 0, DateTimeKind.Unspecified),
                            SpecialRequest = "Double Table"
                        });
                });

            modelBuilder.Entity("GraphQlPlayground.Models.Menu", b =>
                {
                    b.HasOne("GraphQlPlayground.Models.Category", null)
                        .WithMany("menus")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GraphQlPlayground.Models.Category", b =>
                {
                    b.Navigation("menus");
                });
#pragma warning restore 612, 618
        }
    }
}
