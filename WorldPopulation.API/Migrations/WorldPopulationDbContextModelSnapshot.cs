﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldPopulation.API.Data;

namespace WorldPopulation.API.Migrations
{
    [DbContext(typeof(WorldPopulationDbContext))]
    partial class WorldPopulationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldPopulation.API.Models.CountryPopulation", b =>
                {
                    b.Property<int>("CountryPopulationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coutry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Density")
                        .HasColumnType("int");

                    b.Property<int>("LandArea")
                        .HasColumnType("int");

                    b.Property<int>("NetChange")
                        .HasColumnType("int");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.Property<double>("YearlyChange")
                        .HasColumnType("float");

                    b.HasKey("CountryPopulationID");

                    b.ToTable("CountryPopulations");

                    b.HasData(
                        new
                        {
                            CountryPopulationID = 1,
                            Coutry = "China",
                            Density = 153,
                            LandArea = 9388211,
                            NetChange = 5540090,
                            Population = 1439323776L,
                            YearlyChange = 0.39000000000000001
                        },
                        new
                        {
                            CountryPopulationID = 2,
                            Coutry = "India",
                            Density = 464,
                            LandArea = 2973190,
                            NetChange = 13586631,
                            Population = 1380004385L,
                            YearlyChange = 0.98999999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
