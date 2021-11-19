﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkApi.Models;

namespace ParkApi.Migrations
{
    [DbContext(typeof(ParkApiContext))]
    [Migration("20211119011603_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ParkApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Name = "Big Bend",
                            Rating = 8,
                            State = "Texas",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 2,
                            Name = "Big Bend",
                            Rating = 10,
                            State = "Texas",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 3,
                            Name = "Crater Lake",
                            Rating = 10,
                            State = "Oregon",
                            Type = "National"
                        },
                        new
                        {
                            ParkId = 4,
                            Name = "Bastrop",
                            Rating = 5,
                            State = "Texas",
                            Type = "State"
                        },
                        new
                        {
                            ParkId = 5,
                            Name = "Dead Horse Point",
                            Rating = 7,
                            State = "Utah",
                            Type = "State"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
