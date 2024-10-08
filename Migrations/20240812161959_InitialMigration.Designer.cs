﻿// <auto-generated />
using System;
using GalleryCafe.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryCafe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240812161959_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("GalleryCafe.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GalleryCafe.Models.MealType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("MealTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Morning meals",
                            Name = "Breakfast"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Midday meals",
                            Name = "Lunch"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Evening meals",
                            Name = "Dinner"
                        });
                });

            modelBuilder.Entity("GalleryCafe.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CuisineType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MealTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("MealTypeId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CuisineType = "American",
                            Description = "Fluffy pancakes",
                            ImageUrl = "/images/pancakes.jpg",
                            MealTypeId = 1,
                            Name = "Pancakes",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = 2,
                            CuisineType = "Italian",
                            Description = "Classic Italian pasta",
                            ImageUrl = "/images/spaghetti.jpg",
                            MealTypeId = 2,
                            Name = "Spaghetti",
                            Price = 12.99m
                        },
                        new
                        {
                            Id = 3,
                            CuisineType = "Sri Lankan",
                            Description = "Spicy Sri Lankan curry",
                            ImageUrl = "/images/chicken_curry.jpg",
                            MealTypeId = 3,
                            Name = "Chicken Curry",
                            Price = 10.99m
                        },
                        new
                        {
                            Id = 4,
                            CuisineType = "American",
                            Description = "Golden brown French toast",
                            ImageUrl = "/images/french_toast.jpg",
                            MealTypeId = 1,
                            Name = "French Toast",
                            Price = 6.99m
                        },
                        new
                        {
                            Id = 5,
                            CuisineType = "Italian",
                            Description = "Crispy romaine with Caesar dressing",
                            ImageUrl = "/images/caesar_salad.jpg",
                            MealTypeId = 2,
                            Name = "Caesar Salad",
                            Price = 7.99m
                        },
                        new
                        {
                            Id = 6,
                            CuisineType = "Thai",
                            Description = "Spicy and sour Thai soup",
                            ImageUrl = "/images/tom_yum.jpg",
                            MealTypeId = 3,
                            Name = "Tom Yum Soup",
                            Price = 8.99m
                        },
                        new
                        {
                            Id = 7,
                            CuisineType = "American",
                            Description = "Toasted bagel with creamy cheese",
                            ImageUrl = "/images/bagel.jpg",
                            MealTypeId = 1,
                            Name = "Bagel with Cream Cheese",
                            Price = 4.99m
                        },
                        new
                        {
                            Id = 8,
                            CuisineType = "French",
                            Description = "Classic French vegetable stew",
                            ImageUrl = "/images/ratatouille.jpg",
                            MealTypeId = 2,
                            Name = "Ratatouille",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = 9,
                            CuisineType = "Indian",
                            Description = "Fragrant rice with spiced chicken",
                            ImageUrl = "/images/biryani.jpg",
                            MealTypeId = 3,
                            Name = "Chicken Biryani",
                            Price = 11.99m
                        },
                        new
                        {
                            Id = 10,
                            CuisineType = "American",
                            Description = "Crispy waffles with syrup",
                            ImageUrl = "/images/waffles.jpg",
                            MealTypeId = 1,
                            Name = "Waffles",
                            Price = 5.49m
                        },
                        new
                        {
                            Id = 11,
                            CuisineType = "Italian",
                            Description = "Layered pasta with cheese and meat",
                            ImageUrl = "/images/lasagna.jpg",
                            MealTypeId = 2,
                            Name = "Lasagna",
                            Price = 13.49m
                        },
                        new
                        {
                            Id = 12,
                            CuisineType = "Thai",
                            Description = "Stir-fried noodles with shrimp",
                            ImageUrl = "/images/pad_thai.jpg",
                            MealTypeId = 3,
                            Name = "Pad Thai",
                            Price = 10.49m
                        },
                        new
                        {
                            Id = 13,
                            CuisineType = "American",
                            Description = "Poached eggs with hollandaise sauce",
                            ImageUrl = "/images/eggs_benedict.jpg",
                            MealTypeId = 1,
                            Name = "Eggs Benedict",
                            Price = 7.99m
                        },
                        new
                        {
                            Id = 14,
                            CuisineType = "Italian",
                            Description = "Classic pizza with tomatoes and basil",
                            ImageUrl = "/images/margherita.jpg",
                            MealTypeId = 2,
                            Name = "Margherita Pizza",
                            Price = 9.49m
                        },
                        new
                        {
                            Id = 15,
                            CuisineType = "Indonesian",
                            Description = "Rich and tender slow-cooked beef",
                            ImageUrl = "/images/rendang.jpg",
                            MealTypeId = 3,
                            Name = "Beef Rendang",
                            Price = 12.99m
                        },
                        new
                        {
                            Id = 16,
                            CuisineType = "American",
                            Description = "Smashed avocado on sourdough toast",
                            ImageUrl = "/images/avocado_toast.jpg",
                            MealTypeId = 1,
                            Name = "Avocado Toast",
                            Price = 6.49m
                        },
                        new
                        {
                            Id = 17,
                            CuisineType = "Italian",
                            Description = "Pasta with creamy Alfredo sauce",
                            ImageUrl = "/images/fettuccine.jpg",
                            MealTypeId = 2,
                            Name = "Fettuccine Alfredo",
                            Price = 11.49m
                        },
                        new
                        {
                            Id = 18,
                            CuisineType = "Thai",
                            Description = "Thai green curry with chicken",
                            ImageUrl = "/images/green_curry.jpg",
                            MealTypeId = 3,
                            Name = "Green Curry",
                            Price = 9.99m
                        });
                });

            modelBuilder.Entity("GalleryCafe.Models.ParkingSpot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("ParkingSpots");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 2,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 3,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 4,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 5,
                            IsAvailable = true
                        });
                });

            modelBuilder.Entity("GalleryCafe.Models.PreOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.ToTable("PreOrders");
                });

            modelBuilder.Entity("GalleryCafe.Models.PreOrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("PreOrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("SpecialInstructions")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("PreOrderId");

                    b.ToTable("PreOrderItems");
                });

            modelBuilder.Entity("GalleryCafe.Models.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Promotions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "50% off on all desserts",
                            EndDate = new DateTime(2024, 9, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5260),
                            ImageUrl = "/images/summer_special.jpg",
                            StartDate = new DateTime(2024, 8, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5220),
                            Title = "Summer Special"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Buy 1 Get 1 Free on cocktails",
                            EndDate = new DateTime(2024, 9, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5260),
                            ImageUrl = "/images/happy_hour.jpg",
                            StartDate = new DateTime(2024, 8, 12, 21, 49, 59, 83, DateTimeKind.Local).AddTicks(5260),
                            Title = "Happy Hour"
                        });
                });

            modelBuilder.Entity("GalleryCafe.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("ParkingSpotId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParkingSpotId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("GalleryCafe.Models.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 4,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 4,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 5,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 5,
                            IsAvailable = true
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 5,
                            IsAvailable = true
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GalleryCafe.Models.MenuItem", b =>
                {
                    b.HasOne("GalleryCafe.Models.MealType", "MealType")
                        .WithMany("MenuItems")
                        .HasForeignKey("MealTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MealType");
                });

            modelBuilder.Entity("GalleryCafe.Models.PreOrder", b =>
                {
                    b.HasOne("GalleryCafe.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("GalleryCafe.Models.PreOrderItem", b =>
                {
                    b.HasOne("GalleryCafe.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalleryCafe.Models.PreOrder", "PreOrder")
                        .WithMany("PreOrderItems")
                        .HasForeignKey("PreOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("PreOrder");
                });

            modelBuilder.Entity("GalleryCafe.Models.Reservation", b =>
                {
                    b.HasOne("GalleryCafe.Models.ParkingSpot", "ParkingSpot")
                        .WithMany()
                        .HasForeignKey("ParkingSpotId");

                    b.HasOne("GalleryCafe.Models.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParkingSpot");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GalleryCafe.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GalleryCafe.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GalleryCafe.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GalleryCafe.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GalleryCafe.Models.MealType", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("GalleryCafe.Models.PreOrder", b =>
                {
                    b.Navigation("PreOrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
