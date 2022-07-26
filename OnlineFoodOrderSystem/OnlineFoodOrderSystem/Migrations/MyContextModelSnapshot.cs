﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineFoodOrderSystem;

namespace OnlineFoodOrderSystem.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineFoodOrderSystem.Entities.Admin", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<long>("Mobile")
                        .HasColumnType("Bigint");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Userid");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("OnlineFoodOrderSystem.Entities.Customer", b =>
                {
                    b.Property<int>("Customerid")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<long>("Mobile")
                        .HasColumnType("Bigint");

                    b.Property<string>("Password")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Status")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("lastName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Customerid");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("OnlineFoodOrderSystem.Entities.Menu", b =>
                {
                    b.Property<int>("Menuid")
                        .HasColumnType("int");

                    b.Property<string>("FoodCategory")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MenuName")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Menuid");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("OnlineFoodOrderSystem.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Customerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal");

                    b.HasKey("OrderId");

                    b.HasIndex("Customerid");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OnlineFoodOrderSystem.Entities.Order", b =>
                {
                    b.HasOne("OnlineFoodOrderSystem.Entities.Customer", "customer")
                        .WithMany()
                        .HasForeignKey("Customerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });
#pragma warning restore 612, 618
        }
    }
}
