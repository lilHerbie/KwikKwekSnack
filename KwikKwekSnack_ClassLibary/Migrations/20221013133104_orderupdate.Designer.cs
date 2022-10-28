﻿// <auto-generated />
using System;
using KwikKwekSnack_ClassLibary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    [DbContext(typeof(KwikKwekSnackContext))]
    [Migration("20221013133104_orderupdate")]
    partial class orderupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrinkId"), 1L, 1);

                    b.Property<bool>("Ice")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<bool>("Straw")
                        .HasColumnType("bit");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int?>("DrinkId")
                        .HasColumnType("int");

                    b.Property<int?>("SnackId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.HasIndex("DrinkId");

                    b.HasIndex("SnackId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Snack", b =>
                {
                    b.Property<int>("SnackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SnackId"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StartPrice")
                        .HasColumnType("int");

                    b.Property<int>("extra")
                        .HasColumnType("int");

                    b.HasKey("SnackId");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Drink", null)
                        .WithMany("Orders")
                        .HasForeignKey("DrinkId");

                    b.HasOne("KwikKwekSnack_ClassLibary.Snack", null)
                        .WithMany("Orders")
                        .HasForeignKey("SnackId");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Drink", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Snack", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
