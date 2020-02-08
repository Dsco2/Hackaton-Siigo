﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20200208172510_AddRelationships")]
    partial class AddRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Business.Entities.Customer", b =>
                {
                    b.Property<int>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<int?>("IdTenant");

                    b.Property<string>("LastName");

                    b.HasKey("IdCustomer");

                    b.HasIndex("IdTenant");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("Business.Entities.Invoice", b =>
                {
                    b.Property<int>("IdInvoice")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DocDate");

                    b.Property<string>("DocNumber");

                    b.Property<int?>("IdCustomer");

                    b.Property<int?>("IdTenant");

                    b.Property<int>("TotalDiscount");

                    b.Property<int>("TotalTax");

                    b.Property<int>("TotalValue");

                    b.HasKey("IdInvoice");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdTenant");

                    b.ToTable("ac_invoices");
                });

            modelBuilder.Entity("Business.Entities.InvoiceItem", b =>
                {
                    b.Property<int>("IdInvoiceItem")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IdInvoice");

                    b.Property<int?>("IdProduct");

                    b.Property<int?>("IdTenant");

                    b.Property<float>("ItemValue");

                    b.Property<float>("Quantity");

                    b.Property<float>("UnitValue");

                    b.HasKey("IdInvoiceItem");

                    b.HasIndex("IdInvoice");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdTenant");

                    b.ToTable("ac_invoice_items");
                });

            modelBuilder.Entity("Business.Entities.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("IdTenant");

                    b.Property<float>("ListPrice");

                    b.Property<string>("Name");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdTenant");

                    b.ToTable("ac_products");
                });

            modelBuilder.Entity("Business.Entities.Tenant", b =>
                {
                    b.Property<int>("IdTenant")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("IdTenant");

                    b.ToTable("ac_tenant");
                });

            modelBuilder.Entity("Business.Entities.Customer", b =>
                {
                    b.HasOne("Business.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("IdTenant");
                });

            modelBuilder.Entity("Business.Entities.Invoice", b =>
                {
                    b.HasOne("Business.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer");

                    b.HasOne("Business.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("IdTenant");
                });

            modelBuilder.Entity("Business.Entities.InvoiceItem", b =>
                {
                    b.HasOne("Business.Entities.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("IdInvoice");

                    b.HasOne("Business.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct");

                    b.HasOne("Business.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("IdTenant");
                });

            modelBuilder.Entity("Business.Entities.Product", b =>
                {
                    b.HasOne("Business.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("IdTenant");
                });
#pragma warning restore 612, 618
        }
    }
}