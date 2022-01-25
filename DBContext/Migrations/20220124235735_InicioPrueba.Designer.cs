﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModeloDB;

namespace ModeloDB.Migrations
{
    [DbContext(typeof(Repositorio))]
    [Migration("20220124235735_InicioPrueba")]
    partial class InicioPrueba
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Modelo.Endidades.Film", b =>
                {
                    b.Property<int>("filmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fulltext")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("languageId")
                        .HasColumnType("int");

                    b.Property<int>("language_Id")
                        .HasColumnType("int");

                    b.Property<string>("last_update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("length")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rating")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("release_year")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rental_duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rental_rate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("replacement_cost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("special_features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("filmId");

                    b.HasIndex("languageId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Modelo.Endidades.Inventory", b =>
                {
                    b.Property<int>("inventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("filmId")
                        .HasColumnType("int");

                    b.Property<int>("film_Id")
                        .HasColumnType("int");

                    b.Property<string>("last_update")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("store_Id")
                        .HasColumnType("int");

                    b.HasKey("inventoryId");

                    b.HasIndex("filmId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("Modelo.Endidades.Language", b =>
                {
                    b.Property<int>("languageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_update")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("languageId");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("Modelo.Endidades.Film", b =>
                {
                    b.HasOne("Modelo.Endidades.Language", "language")
                        .WithMany()
                        .HasForeignKey("languageId");

                    b.Navigation("language");
                });

            modelBuilder.Entity("Modelo.Endidades.Inventory", b =>
                {
                    b.HasOne("Modelo.Endidades.Film", "film")
                        .WithMany()
                        .HasForeignKey("filmId");

                    b.Navigation("film");
                });
#pragma warning restore 612, 618
        }
    }
}