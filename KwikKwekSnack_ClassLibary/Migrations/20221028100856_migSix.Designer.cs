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
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221028100856_migSix")]
    partial class migSix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExtraSnackLine", b =>
                {
                    b.Property<int>("ExtrasId")
                        .HasColumnType("int");

                    b.Property<int>("SnackLinesId")
                        .HasColumnType("int");

                    b.HasKey("ExtrasId", "SnackLinesId");

                    b.HasIndex("SnackLinesId");

                    b.ToTable("ExtraSnackLine");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Drink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StartPrice")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.DrinkLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DrinkID")
                        .HasColumnType("int");

                    b.Property<bool>("HasIce")
                        .HasColumnType("bit");

                    b.Property<bool>("HasStraw")
                        .HasColumnType("bit");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DrinkID");

                    b.HasIndex("OrderId");

                    b.ToTable("DrinkLines");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Snack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("StartPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Snacks");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.SnackLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SnackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("SnackId");

                    b.ToTable("SnackLines");
                });

            modelBuilder.Entity("ExtraSnackLine", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Extra", null)
                        .WithMany()
                        .HasForeignKey("ExtrasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KwikKwekSnack_ClassLibary.SnackLine", null)
                        .WithMany()
                        .HasForeignKey("SnackLinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.DrinkLine", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KwikKwekSnack_ClassLibary.Order", null)
                        .WithMany("Drinks")
                        .HasForeignKey("OrderId");

                    b.Navigation("Drink");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.SnackLine", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Order", null)
                        .WithMany("Snacks")
                        .HasForeignKey("OrderId");

                    b.HasOne("KwikKwekSnack_ClassLibary.Snack", "Snack")
                        .WithMany()
                        .HasForeignKey("SnackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Snack");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.Navigation("Drinks");

                    b.Navigation("Snacks");
                });
#pragma warning restore 612, 618
        }
    }
}
