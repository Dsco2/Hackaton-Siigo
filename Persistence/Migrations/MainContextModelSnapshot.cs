﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("IdTenant");

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

                    b.Property<int>("IdTenant");

                    b.Property<float>("ListPrice");

                    b.Property<string>("Name");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdTenant");

                    b.ToTable("ac_products");

                    b.HasData(
                        new { IdProduct = 1, Description = "Billetera negra de cuero", IdTenant = 3, ListPrice = 100000f, Name = "Billetera negra" },
                        new { IdProduct = 2, Description = "Billeteras artesanales de cuero", IdTenant = 3, ListPrice = 75000f, Name = "Billeteras artesanales" },
                        new { IdProduct = 3, Description = "Biiletera gris de cuero", IdTenant = 3, ListPrice = 350000f, Name = "Biiletera gris" },
                        new { IdProduct = 4, Description = "Billetera importada de cuero", IdTenant = 3, ListPrice = 350001f, Name = "Billetera importada" },
                        new { IdProduct = 5, Description = "Sombreros para hombre de cuero", IdTenant = 3, ListPrice = 350002f, Name = "Sombreros para hombre" },
                        new { IdProduct = 6, Description = "Cinturón para hombre de cuero", IdTenant = 3, ListPrice = 350003f, Name = "Cinturón para hombre" },
                        new { IdProduct = 7, Description = "Cinturón para mujer de cuero", IdTenant = 3, ListPrice = 350004f, Name = "Cinturón para mujer" },
                        new { IdProduct = 8, Description = "Cinturón importado de cuero", IdTenant = 3, ListPrice = 350005f, Name = "Cinturón importado" },
                        new { IdProduct = 9, Description = "Billetera para mujer de cuero", IdTenant = 3, ListPrice = 350006f, Name = "Billetera para mujer" },
                        new { IdProduct = 10, Description = "Cinturón con diseños de cuero", IdTenant = 3, ListPrice = 350007f, Name = "Cinturón con diseños" },
                        new { IdProduct = 11, Description = "Cinturón artesanal de cuero", IdTenant = 3, ListPrice = 350008f, Name = "Cinturón artesanal" },
                        new { IdProduct = 12, Description = "Billetera para Hombre de cuero", IdTenant = 3, ListPrice = 350009f, Name = "Billetera para Hombre" },
                        new { IdProduct = 13, Description = "Sombreros para mujer de cuero", IdTenant = 3, ListPrice = 350003f, Name = "Sombreros para mujer" },
                        new { IdProduct = 14, Description = "Chaqueta tipo motociclista de cuero", IdTenant = 3, ListPrice = 350004f, Name = "Chaqueta tipo motociclista" },
                        new { IdProduct = 15, Description = "Chaqueta importada de cuero", IdTenant = 3, ListPrice = 350005f, Name = "Chaqueta importada" },
                        new { IdProduct = 16, Description = "Chaqueta artesanal de cuero", IdTenant = 3, ListPrice = 350006f, Name = "Chaqueta artesanal" },
                        new { IdProduct = 17, Description = "Chaqueta para mujer de cuero", IdTenant = 3, ListPrice = 350007f, Name = "Chaqueta para mujer" },
                        new { IdProduct = 18, Description = "Chaqueta para hombre de cuero", IdTenant = 3, ListPrice = 350007f, Name = "Chaqueta para hombre" },
                        new { IdProduct = 19, Description = "Sombrero importado de cuero", IdTenant = 3, ListPrice = 200000f, Name = "Sombrero importado" },
                        new { IdProduct = 20, Description = "Papa criolla marca Jumbo", IdTenant = 2, ListPrice = 5646f, Name = "Papa criolla" },
                        new { IdProduct = 21, Description = "Papa sabadera marca Jumbo", IdTenant = 2, ListPrice = 45645f, Name = "Papa sabadera" },
                        new { IdProduct = 22, Description = "Papa importada marca Jumbo", IdTenant = 2, ListPrice = 3546f, Name = "Papa importada" },
                        new { IdProduct = 23, Description = "Papas fritas marca Jumbo", IdTenant = 2, ListPrice = 64554f, Name = "Papas fritas" },
                        new { IdProduct = 24, Description = "Papas  marca Jumbo", IdTenant = 2, ListPrice = 15616f, Name = "Papas " },
                        new { IdProduct = 25, Description = "Tomates marca Jumbo", IdTenant = 2, ListPrice = 65464f, Name = "Tomates" },
                        new { IdProduct = 26, Description = "Piñas marca Jumbo", IdTenant = 2, ListPrice = 4468f, Name = "Piñas" },
                        new { IdProduct = 27, Description = "Cebollas marca Jumbo", IdTenant = 2, ListPrice = 114f, Name = "Cebollas" },
                        new { IdProduct = 28, Description = "Leche marca Exito", IdTenant = 1, ListPrice = 56454f, Name = "Leche" },
                        new { IdProduct = 29, Description = "Leche entera marca Exito", IdTenant = 1, ListPrice = 100000f, Name = "Leche entera" },
                        new { IdProduct = 30, Description = "Leche deslactosada marca Exito", IdTenant = 1, ListPrice = 654654f, Name = "Leche deslactosada" },
                        new { IdProduct = 31, Description = "Leche descremada marca Exito", IdTenant = 1, ListPrice = 45655f, Name = "Leche descremada" },
                        new { IdProduct = 32, Description = "Leche de almendras marca Exito", IdTenant = 1, ListPrice = 5454f, Name = "Leche de almendras" },
                        new { IdProduct = 33, Description = "Leche de soja marca Exito", IdTenant = 1, ListPrice = 5456f, Name = "Leche de soja" },
                        new { IdProduct = 34, Description = "Arroz integral marca Exito", IdTenant = 1, ListPrice = 8785f, Name = "Arroz integral" },
                        new { IdProduct = 35, Description = "Ropa informal marca Exito", IdTenant = 1, ListPrice = 2156f, Name = "Ropa informal" },
                        new { IdProduct = 36, Description = "Arroz marca Exito", IdTenant = 1, ListPrice = 65464f, Name = "Arroz" },
                        new { IdProduct = 37, Description = "Frijol marca Exito", IdTenant = 1, ListPrice = 6554654f, Name = "Frijol" },
                        new { IdProduct = 38, Description = "Ropa formal marca Exito", IdTenant = 1, ListPrice = 6546f, Name = "Ropa formal" },
                        new { IdProduct = 39, Description = "Carnes congeladas marca Exito", IdTenant = 1, ListPrice = 65465f, Name = "Carnes congeladas" }
                    );
                });

            modelBuilder.Entity("Business.Entities.SearchCustomerHistory", b =>
                {
                    b.Property<int>("IdSearchCustomerHistory")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfSearch");

                    b.Property<int>("IdCustomer");

                    b.HasKey("IdSearchCustomerHistory");

                    b.HasIndex("IdCustomer");

                    b.ToTable("search_customer_history");
                });

            modelBuilder.Entity("Business.Entities.SearchProductHistory", b =>
                {
                    b.Property<int>("IdSearchProductHistory")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfSearch");

                    b.Property<int>("IdProduct");

                    b.HasKey("IdSearchProductHistory");

                    b.HasIndex("IdProduct");

                    b.ToTable("search_history");
                });

            modelBuilder.Entity("Business.Entities.Tenant", b =>
                {
                    b.Property<int>("IdTenant")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Theme");

                    b.HasKey("IdTenant");

                    b.ToTable("ac_tenant");

                    b.HasData(
                        new { IdTenant = 1, Name = "Exito", Theme = "warning" },
                        new { IdTenant = 2, Name = "Jumbo", Theme = "primary" },
                        new { IdTenant = 3, Name = "Cueros SAS", Theme = "info" }
                    );
                });

            modelBuilder.Entity("Business.Entities.Customer", b =>
                {
                    b.HasOne("Business.Entities.Tenant", "Tenant")
                        .WithMany()
                        .HasForeignKey("IdTenant")
                        .OnDelete(DeleteBehavior.Cascade);
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
                        .HasForeignKey("IdTenant")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Business.Entities.SearchCustomerHistory", b =>
                {
                    b.HasOne("Business.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Business.Entities.SearchProductHistory", b =>
                {
                    b.HasOne("Business.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
