﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotNet_GK_QUANLYTHUEXEOTO.Model.Data;

#nullable disable

namespace dotNet_GK_QUANLYTHUEXEOTO.Migrations
{
    [DbContext(typeof(BookingCarDbContext))]
    partial class BookingCarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Account", b =>
                {
                    b.Property<string>("EmployeeEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeEmail");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuelId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FuelId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Car", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CarTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = "75H7777",
                            CarTypeId = 2,
                            Manufacturer = "Tesla",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "92H1010",
                            CarTypeId = 1,
                            Manufacturer = "Huynhdai",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "75H0123",
                            CarTypeId = 3,
                            Manufacturer = "KIA",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "75H6789",
                            CarTypeId = 4,
                            Manufacturer = "Tesla",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "92H0123",
                            CarTypeId = 5,
                            Manufacturer = "Audi",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "92H6789",
                            CarTypeId = 6,
                            Manufacturer = "Porsche",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "75H6666",
                            CarTypeId = 1,
                            Manufacturer = "Vinfast",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "75H1111",
                            CarTypeId = 4,
                            Manufacturer = "Mazda",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "92H1111",
                            CarTypeId = 5,
                            Manufacturer = "Tesla",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "92H2222",
                            CarTypeId = 6,
                            Manufacturer = "Vinfast",
                            Model = "2023",
                            Status = 0
                        },
                        new
                        {
                            Id = "75H2222",
                            CarTypeId = 7,
                            Manufacturer = "Huynhdai",
                            Model = "2023",
                            Status = 0
                        });
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.CarType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CarImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("RentPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CarTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarImage = "../../../Resources/Images/CarTypes/MINI.png",
                            Name = "4 chỗ (Mini)",
                            RentPrice = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            CarImage = "../../../Resources/Images/CarTypes/SEDAN.png",
                            Name = "4 chỗ (Sedan)",
                            RentPrice = 1200.0
                        },
                        new
                        {
                            Id = 3,
                            CarImage = "../../../Resources/Images/CarTypes/HATCHBACK.png",
                            Name = "4 chỗ (Hatchback)",
                            RentPrice = 1500.0
                        },
                        new
                        {
                            Id = 4,
                            CarImage = "../../../Resources/Images/CarTypes/CUV.png",
                            Name = "5 chỗ (CUV Gầm cao)",
                            RentPrice = 2000.0
                        },
                        new
                        {
                            Id = 5,
                            CarImage = "../../../Resources/Images/CarTypes/SUV.png",
                            Name = "7 chỗ (SUV Gầm cao)",
                            RentPrice = 4000.0
                        },
                        new
                        {
                            Id = 6,
                            CarImage = "../../../Resources/Images/CarTypes/MPV.png",
                            Name = "7 chỗ (MPV Gầm thấp)",
                            RentPrice = 3000.0
                        },
                        new
                        {
                            Id = 7,
                            CarImage = "../../../Resources/Images/CarTypes/PICKUP.png",
                            Name = "Bán tải",
                            RentPrice = 500.0
                        });
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasMaxLength(100)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bản đồ",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Camera cập lề",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cảm biến lốp",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Cửa số trời",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Khe cắm USB",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Nắp thùng xe bán tải",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bluetooth",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 8,
                            Name = "Camera hành trình",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cảm biến va chạm",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 10,
                            Name = "Định vị GPS",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 11,
                            Name = "Lốp dự phòng",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 12,
                            Name = "Camera 360",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 13,
                            Name = "Camera lùi",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 14,
                            Name = "Cảnh báo tốc độ",
                            Price = 1000.0
                        });
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasMaxLength(100)
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Fuels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Xăng",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dầu Diesel",
                            Price = 1500.0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Điện",
                            Price = 2000.0
                        });
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Account", b =>
                {
                    b.HasOne("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Booking", b =>
                {
                    b.HasOne("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");

                    b.Navigation("Fuel");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Car", b =>
                {
                    b.HasOne("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.CarType", "CarType")
                        .WithMany()
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarType");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Feature", b =>
                {
                    b.HasOne("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Booking", null)
                        .WithMany("Features")
                        .HasForeignKey("BookingId");
                });

            modelBuilder.Entity("dotNet_GK_QUANLYTHUEXEOTO.Model.Domain.Booking", b =>
                {
                    b.Navigation("Features");
                });
#pragma warning restore 612, 618
        }
    }
}
