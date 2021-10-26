﻿// <auto-generated />
using ECBATS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECBATS.Migrations
{
    [DbContext(typeof(dbcontext.ProductDbContext))]
    [Migration("20211026103858_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("ECBATS.Data.Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CryptoName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Percent24h")
                        .HasColumnType("TEXT");

                    b.Property<string>("Percent7j")
                        .HasColumnType("TEXT");

                    b.Property<string>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Symbol")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = 1001L,
                            CryptoName = "Laptop",
                            Percent24h = "50%",
                            Price = "20.02",
                            Symbol = "10"
                        },
                        new
                        {
                            ID = 1002L,
                            CryptoName = "Microsoft Office",
                            Percent24h = "20%",
                            Price = "20.99",
                            Symbol = "50"
                        },
                        new
                        {
                            ID = 1003L,
                            CryptoName = "Lazer Mouse",
                            Percent24h = "3%",
                            Price = "12.02",
                            Symbol = "20"
                        },
                        new
                        {
                            ID = 1004L,
                            CryptoName = "USB Storage",
                            Percent24h = "95%",
                            Price = "5.00",
                            Symbol = "20"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
