﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RAS.Bootcamp.Mvc.Net.Models;

#nullable disable

namespace RAS.Bootcamp.Mvc.Net.Models.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RAS.Bootcamp.Mvc.Net.Models.Entities.Barang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Harga")
                        .HasColumnType("numeric");

                    b.Property<int>("IdPenjual")
                        .HasColumnType("integer");

                    b.Property<string>("Kode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("Stok")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdPenjual");

                    b.ToTable("Barangs");
                });

            modelBuilder.Entity("RAS.Bootcamp.Mvc.Net.Models.Entities.Penjual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<string>("NamaToko")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("IdUser");

                    b.ToTable("Penjuals");
                });

            modelBuilder.Entity("RAS.Bootcamp.Mvc.Net.Models.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tipe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RAS.Bootcamp.Mvc.Net.Models.Entities.Barang", b =>
                {
                    b.HasOne("RAS.Bootcamp.Mvc.Net.Models.Entities.Penjual", "Penjual")
                        .WithMany("Barangs")
                        .HasForeignKey("IdPenjual")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Penjual");
                });

            modelBuilder.Entity("RAS.Bootcamp.Mvc.Net.Models.Entities.Penjual", b =>
                {
                    b.HasOne("RAS.Bootcamp.Mvc.Net.Models.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RAS.Bootcamp.Mvc.Net.Models.Entities.Penjual", b =>
                {
                    b.Navigation("Barangs");
                });
#pragma warning restore 612, 618
        }
    }
}
