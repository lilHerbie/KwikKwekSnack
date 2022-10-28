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
    [Migration("20221013133532_relation-update")]
    partial class relationupdate
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

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<bool>("Straw")
                        .HasColumnType("bit");

                    b.HasKey("DrinkId");

                    b.HasIndex("OrderId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

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

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StartPrice")
                        .HasColumnType("int");

                    b.Property<int>("extra")
                        .HasColumnType("int");

                    b.HasKey("SnackId");

                    b.HasIndex("OrderId");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Drink", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Order", null)
                        .WithMany("Drink")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Snack", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Order", null)
                        .WithMany("Snack")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.Navigation("Drink");

                    b.Navigation("Snack");
                });
#pragma warning restore 612, 618
        }
    }
}