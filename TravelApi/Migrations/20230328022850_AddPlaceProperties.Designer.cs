﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20230328022850_AddPlaceProperties")]
    partial class AddPlaceProperties
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Place", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("longtext");

                    b.Property<string>("SeasonVisited")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("User_Name")
                        .HasColumnType("longtext");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");
                });
#pragma warning restore 612, 618
        }
    }
}