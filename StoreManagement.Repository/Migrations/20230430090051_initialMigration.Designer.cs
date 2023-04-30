﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreManagement.Repository.DatabaseContext;

#nullable disable

namespace StoreManagement.Repository.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20230430090051_initialMigration")]
    partial class initialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoreManagement.Domain.Models.BusinessEntity.BusinessEntityModel", b =>
                {
                    b.Property<Guid>("BusinessEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("BusinessEntityId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("BusinessEntities");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Employee.EmployeeModel", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeeId");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeModel");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Inventory.InventoryModel", b =>
                {
                    b.Property<Guid>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitCost")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.HasKey("InventoryId");

                    b.HasIndex("BusinessEntityId");

                    b.HasIndex("ProductId");

                    b.ToTable("InventoryModel");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Permissions.PermissionModel", b =>
                {
                    b.Property<Guid>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PermissionId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Permissions.SecurityRoleAssociationModel", b =>
                {
                    b.Property<Guid>("SecurityRoleAssociationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SecurityRoleAssociationId");

                    b.HasIndex("BusinessEntityId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId", "PermissionId", "BusinessEntityId")
                        .IsUnique();

                    b.ToTable("SecurityRoleAssociations");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Product.ProductModel", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedReason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ProductId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Purchase.PurchaseModel", b =>
                {
                    b.Property<Guid>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BusinessEntiyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PurchaseId");

                    b.HasIndex("BusinessEntityId");

                    b.HasIndex("UserId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Purchase.PurchaseProductModel", b =>
                {
                    b.Property<Guid>("PurchaseProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PurchaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantity")
                        .HasPrecision(10, 4)
                        .HasColumnType("decimal(10,4)");

                    b.HasKey("PurchaseProductId");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("ProductId", "PurchaseId")
                        .IsUnique();

                    b.ToTable("PurchaseProducts");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.User.UserModel", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UserId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Employee.EmployeeModel", b =>
                {
                    b.HasOne("StoreManagement.Domain.Models.User.UserModel", "User")
                        .WithMany("Employees")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Inventory.InventoryModel", b =>
                {
                    b.HasOne("StoreManagement.Domain.Models.BusinessEntity.BusinessEntityModel", "BusinessEntity")
                        .WithMany()
                        .HasForeignKey("BusinessEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Domain.Models.Product.ProductModel", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessEntity");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Permissions.SecurityRoleAssociationModel", b =>
                {
                    b.HasOne("StoreManagement.Domain.Models.BusinessEntity.BusinessEntityModel", "BusinessEntity")
                        .WithMany()
                        .HasForeignKey("BusinessEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Domain.Models.Permissions.PermissionModel", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Domain.Models.User.UserModel", "User")
                        .WithMany("SecurityRoleAssociations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessEntity");

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Purchase.PurchaseModel", b =>
                {
                    b.HasOne("StoreManagement.Domain.Models.BusinessEntity.BusinessEntityModel", "BusinessEntity")
                        .WithMany()
                        .HasForeignKey("BusinessEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Domain.Models.User.UserModel", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessEntity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Purchase.PurchaseProductModel", b =>
                {
                    b.HasOne("StoreManagement.Domain.Models.Product.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Domain.Models.Purchase.PurchaseModel", "Purchase")
                        .WithMany()
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.Product.ProductModel", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("StoreManagement.Domain.Models.User.UserModel", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Purchases");

                    b.Navigation("SecurityRoleAssociations");
                });
#pragma warning restore 612, 618
        }
    }
}
