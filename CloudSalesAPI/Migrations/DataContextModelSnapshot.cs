﻿// <auto-generated />
using System;
using CloudSalesAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CloudSalesAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CloudSalesAPI.Models.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"));

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("CloudSalesAPI.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CloudSalesAPI.Models.PurchasedLicense", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CustomerAccountID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("ValidToDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");


                    b.HasIndex("ProductID", "CustomerAccountID")
                        .IsUnique();

                    b.ToTable("PurchasedLicences");
                });

            modelBuilder.Entity("CloudSalesAPI.Models.Account", b =>
                {
                    b.HasOne("CloudSalesAPI.Models.Customer", null)
                        .WithMany("LinkedAccounts")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CloudSalesAPI.Models.Account", b =>
                {
                    b.Navigation("PurchasedLicense");
                });

            modelBuilder.Entity("CloudSalesAPI.Models.Customer", b =>
                {
                    b.Navigation("LinkedAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
