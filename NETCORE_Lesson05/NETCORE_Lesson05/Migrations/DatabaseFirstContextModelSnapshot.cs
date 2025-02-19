﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCORE_Lesson05.Models;

#nullable disable

namespace NETCORE_Lesson05.Migrations
{
    [DbContext(typeof(DatabaseFirstContext))]
    partial class DatabaseFirstContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NETCORE_Lesson05.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("NAME");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.HasKey("Id")
                        .HasName("PK__CATEGORY__3214EC27BE3D03F0");

                    b.ToTable("CATEGORY", (string)null);
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("ADDRESS");

                    b.Property<string>("Code")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("CODE");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NAME");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("PHONE");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("float")
                        .HasColumnName("TOTAL_PRICE");

                    b.HasKey("Id")
                        .HasName("PK__ORDERS__3214EC2764DF8320");

                    b.ToTable("ORDERS", (string)null);
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.OrdersDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrdersId")
                        .HasColumnType("int")
                        .HasColumnName("ORDERS_ID");

                    b.Property<double?>("Price")
                        .HasColumnType("float")
                        .HasColumnName("PRICE");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("PRODUCT_ID");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("QUANTITY");

                    b.Property<double?>("TotalPrice")
                        .HasColumnType("float")
                        .HasColumnName("TOTAL_PRICE");

                    b.HasKey("Id")
                        .HasName("PK__ORDERS_D__3214EC27C9125678");

                    b.HasIndex("OrdersId");

                    b.HasIndex("ProductId");

                    b.ToTable("ORDERS_DETAIL", (string)null);
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<string>("Images")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("IMAGES");

                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("NAME");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOTE");

                    b.Property<double?>("Price")
                        .HasColumnType("float")
                        .HasColumnName("PRICE");

                    b.HasKey("Id")
                        .HasName("PK__PRODUCT__3214EC27EC2555FB");

                    b.HasIndex("CategoryId");

                    b.ToTable("PRODUCT", (string)null);
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.OrdersDetail", b =>
                {
                    b.HasOne("NETCORE_Lesson05.Models.Order", "Orders")
                        .WithMany("OrdersDetails")
                        .HasForeignKey("OrdersId")
                        .HasConstraintName("FK__ORDERS_DE__ORDER__1BFD2C07");

                    b.HasOne("NETCORE_Lesson05.Models.Product", "Product")
                        .WithMany("OrdersDetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__ORDERS_DE__PRODU__1CF15040");

                    b.Navigation("Orders");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.Product", b =>
                {
                    b.HasOne("NETCORE_Lesson05.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__PRODUCT__CATEGOR__1273C1CD");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.Order", b =>
                {
                    b.Navigation("OrdersDetails");
                });

            modelBuilder.Entity("NETCORE_Lesson05.Models.Product", b =>
                {
                    b.Navigation("OrdersDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
