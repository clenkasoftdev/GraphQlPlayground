﻿// <auto-generated />
using GraphQlPlayground.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraphQlPlayground.Migrations
{
    [DbContext(typeof(GraphQlPlaygroundDbContext))]
    partial class GraphQlPlaygroundDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraphQlPlayground.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cheese Pizza",
                            Name = "Pizza",
                            Price = 10.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cheese Burger",
                            Name = "Burger",
                            Price = 5.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cheese Pasta",
                            Name = "Pasta",
                            Price = 8.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
