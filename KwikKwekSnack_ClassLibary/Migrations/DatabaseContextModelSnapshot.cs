﻿// <auto-generated />
using KwikKwekSnack_ClassLibary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KwikKwekSnack_ClassLibary.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Drink", b =>
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

                    b.Property<decimal>("StartPrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Drinks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cola",
                            ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/11/coca-cola-blik-33cl-800x800-1.jpg",
                            Name = "Cola",
                            StartPrice = 1.50m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fanta",
                            ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/10/9480.jpg",
                            Name = "Fanta",
                            StartPrice = 1.50m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Sprite",
                            ImageUrl = "https://smartkiosk.nl/wp-content/uploads/2021/09/2ad47881-f56c-4237-8574-402a84b96b63.jpg",
                            Name = "Sprite",
                            StartPrice = 1.50m
                        });
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.DrinkLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("DrinkId")
                        .HasColumnType("int");

                    b.Property<bool>("HasIce")
                        .HasColumnType("bit");

                    b.Property<bool>("HasStraw")
                        .HasColumnType("bit");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DrinkId");

                    b.HasIndex("OrderId");

                    b.ToTable("DrinkLines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 2,
                            DrinkId = 1,
                            HasIce = false,
                            HasStraw = false,
                            OrderId = 1,
                            Price = 3.00m,
                            Size = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 1,
                            DrinkId = 2,
                            HasIce = false,
                            HasStraw = true,
                            OrderId = 1,
                            Price = 1.50m,
                            Size = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 1,
                            DrinkId = 3,
                            HasIce = false,
                            HasStraw = true,
                            OrderId = 2,
                            Price = 1.50m,
                            Size = 3
                        });
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

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Extras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ui",
                            Price = 0.30m
                        },
                        new
                        {
                            Id = 2,
                            Name = "Broodje",
                            Price = 1.00m
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tomaat",
                            Price = 0.20m
                        });
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = 0,
                            TotalPrice = 10.00m
                        },
                        new
                        {
                            Id = 2,
                            Status = 0,
                            TotalPrice = 10.00m
                        });
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

                    b.Property<decimal>("StartPrice")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Snacks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Frikandel",
                            ImageUrl = "https://boshuis.huisjebezorgd.nl/wp-content/uploads/2020/03/29512948_652505005141152_1601506864166600704_o.jpg",
                            Name = "Frikandel",
                            StartPrice = 2.50m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Kroket",
                            ImageUrl = "https://images0.persgroep.net/rcs/IFZ8aVdFNg1-Bko2qCSQg5i8G-A/diocontent/101162365/_fitwidth/763?appId=93a17a8fd81db0de025c8abd1cca1279&quality=0.8",
                            Name = "Kroket",
                            StartPrice = 2.75m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bamischijf",
                            ImageUrl = "https://veluwe-plaza.huisjebezorgd.nl/wp-content/uploads/2020/03/bami.jpg",
                            Name = "Bamischijf",
                            StartPrice = 3.00m
                        });
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.SnackLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int>("SnackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("SnackLines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 2,
                            OrderId = 1,
                            Price = 5.00m,
                            SnackId = 1
                        },
                        new
                        {
                            Id = 2,
                            Amount = 1,
                            OrderId = 2,
                            Price = 2.75m,
                            SnackId = 2
                        },
                        new
                        {
                            Id = 3,
                            Amount = 1,
                            OrderId = 2,
                            Price = 2.75m,
                            SnackId = 3
                        });
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.DrinkLine", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Drink", "Drink")
                        .WithMany()
                        .HasForeignKey("DrinkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KwikKwekSnack_ClassLibary.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drink");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KwikKwekSnack_ClassLibary.SnackLine", b =>
                {
                    b.HasOne("KwikKwekSnack_ClassLibary.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
