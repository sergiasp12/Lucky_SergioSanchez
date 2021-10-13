﻿// <auto-generated />
using Lucky_SergioSanchez.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lucky_SergioSanchez.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211013235824_AddModel")]
    partial class AddModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lucky_SergioSanchez.Models.Lucky", b =>
                {
                    b.Property<int>("SuerteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SuerteID");

                    b.ToTable("Lucky");
                });
#pragma warning restore 612, 618
        }
    }
}
