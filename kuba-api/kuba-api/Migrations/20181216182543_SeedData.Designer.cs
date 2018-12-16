﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using kubaapi.Models;

namespace kubaapi.Migrations
{
    [DbContext(typeof(PatientContext))]
    [Migration("20181216182543_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("kubaapi.Models.Patient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<string>("Description");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.HasKey("Id");

                    b.ToTable("Patients");

                    b.HasData(
                        new { Id = 1L, Address = "Irgendwo 12", Age = 5, Description = "Ein ganz lieber Patient", Firstname = "Kleiner", Lastname = "Hase" },
                        new { Id = 2L, Address = "Irgendwo 22", Age = 5, Description = "Ein ganz lieber Patient", Firstname = "Kleiner", Lastname = "Hase 2" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
