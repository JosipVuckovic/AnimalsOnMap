﻿// <auto-generated />
using AnimalsOnMap.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalsOnMap.Migrations
{
    [DbContext(typeof(AnimalsContext))]
    [Migration("20200915214620_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AnimalsOnMap.Data.Classes.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalSpecies")
                        .HasColumnType("int");

                    b.Property<string>("LatinName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Latituda")
                        .HasColumnType("real");

                    b.Property<string>("LocalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Longitude")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Animal");
                });
#pragma warning restore 612, 618
        }
    }
}
