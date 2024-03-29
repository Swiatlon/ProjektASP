﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240207154904_SecondRelation")]
    partial class SecondRelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.26");

            modelBuilder.Entity("Data.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "City1",
                            PostalCode = "100-000",
                            Region = "Region1",
                            Street = "Street1"
                        },
                        new
                        {
                            Id = 2,
                            City = "City2",
                            PostalCode = "200-000",
                            Region = "Region2",
                            Street = "Street2"
                        },
                        new
                        {
                            Id = 3,
                            City = "City3",
                            PostalCode = "300-000",
                            Region = "Region3",
                            Street = "Street3"
                        },
                        new
                        {
                            Id = 4,
                            City = "City4",
                            PostalCode = "400-000",
                            Region = "Region4",
                            Street = "Street4"
                        },
                        new
                        {
                            Id = 5,
                            City = "City5",
                            PostalCode = "500-000",
                            Region = "Region5",
                            Street = "Street5"
                        },
                        new
                        {
                            Id = 6,
                            City = "City6",
                            PostalCode = "600-000",
                            Region = "Region6",
                            Street = "Street6"
                        },
                        new
                        {
                            Id = 7,
                            City = "City7",
                            PostalCode = "700-000",
                            Region = "Region7",
                            Street = "Street7"
                        },
                        new
                        {
                            Id = 8,
                            City = "City8",
                            PostalCode = "800-000",
                            Region = "Region8",
                            Street = "Street8"
                        },
                        new
                        {
                            Id = 9,
                            City = "City9",
                            PostalCode = "900-000",
                            Region = "Region9",
                            Street = "Street9"
                        },
                        new
                        {
                            Id = 10,
                            City = "City10",
                            PostalCode = "1000-000",
                            Region = "Region10",
                            Street = "Street10"
                        });
                });

            modelBuilder.Entity("Data.Entities.ProducerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AddressId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Producers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressId = 1,
                            Description = "Description for Producer1",
                            Name = "Producer1"
                        },
                        new
                        {
                            Id = 2,
                            AddressId = 2,
                            Description = "Description for Producer2",
                            Name = "Producer2"
                        },
                        new
                        {
                            Id = 3,
                            AddressId = 3,
                            Description = "Description for Producer3",
                            Name = "Producer3"
                        },
                        new
                        {
                            Id = 4,
                            AddressId = 4,
                            Description = "Description for Producer4",
                            Name = "Producer4"
                        },
                        new
                        {
                            Id = 5,
                            AddressId = 5,
                            Description = "Description for Producer5",
                            Name = "Producer5"
                        },
                        new
                        {
                            Id = 6,
                            AddressId = 6,
                            Description = "Description for Producer6",
                            Name = "Producer6"
                        },
                        new
                        {
                            Id = 7,
                            AddressId = 7,
                            Description = "Description for Producer7",
                            Name = "Producer7"
                        },
                        new
                        {
                            Id = 8,
                            AddressId = 8,
                            Description = "Description for Producer8",
                            Name = "Producer8"
                        },
                        new
                        {
                            Id = 9,
                            AddressId = 9,
                            Description = "Description for Producer9",
                            Name = "Producer9"
                        },
                        new
                        {
                            Id = 10,
                            AddressId = 10,
                            Description = "Description for Producer10",
                            Name = "Producer10"
                        });
                });

            modelBuilder.Entity("Data.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProducerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProducerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Product1",
                            Name = "Product1",
                            Price = 0.41045240184945900m,
                            ProducerId = 3,
                            ProductionDate = new DateTime(2023, 2, 9, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1483)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Product2",
                            Name = "Product2",
                            Price = 18.727277044399300m,
                            ProducerId = 3,
                            ProductionDate = new DateTime(2023, 6, 27, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1513)
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Product3",
                            Name = "Product3",
                            Price = 88.617618476508200m,
                            ProducerId = 1,
                            ProductionDate = new DateTime(2024, 1, 23, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1517)
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description for Product4",
                            Name = "Product4",
                            Price = 1.7196206886152900m,
                            ProducerId = 4,
                            ProductionDate = new DateTime(2023, 9, 26, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1519)
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description for Product5",
                            Name = "Product5",
                            Price = 19.515694418668900m,
                            ProducerId = 3,
                            ProductionDate = new DateTime(2023, 10, 17, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1521)
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description for Product6",
                            Name = "Product6",
                            Price = 40.298028813647900m,
                            ProducerId = 4,
                            ProductionDate = new DateTime(2023, 7, 19, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1547)
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description for Product7",
                            Name = "Product7",
                            Price = 17.409180896913200m,
                            ProducerId = 5,
                            ProductionDate = new DateTime(2023, 3, 25, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1550)
                        },
                        new
                        {
                            Id = 8,
                            Description = "Description for Product8",
                            Name = "Product8",
                            Price = 28.404295002296300m,
                            ProducerId = 5,
                            ProductionDate = new DateTime(2023, 4, 25, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1553)
                        },
                        new
                        {
                            Id = 9,
                            Description = "Description for Product9",
                            Name = "Product9",
                            Price = 42.734831688275300m,
                            ProducerId = 4,
                            ProductionDate = new DateTime(2023, 9, 16, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1555)
                        },
                        new
                        {
                            Id = 10,
                            Description = "Description for Product10",
                            Name = "Product10",
                            Price = 46.779424198720600m,
                            ProducerId = 2,
                            ProductionDate = new DateTime(2023, 6, 24, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1558)
                        });
                });

            modelBuilder.Entity("Data.Entities.ProducerEntity", b =>
                {
                    b.HasOne("Data.Entities.AddressEntity", "Address")
                        .WithOne()
                        .HasForeignKey("Data.Entities.ProducerEntity", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Data.Entities.ProductEntity", b =>
                {
                    b.HasOne("Data.Entities.ProducerEntity", "Producer")
                        .WithMany("Products")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("Data.Entities.ProducerEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
