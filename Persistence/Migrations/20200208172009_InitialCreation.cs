using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ac_tenant",
                columns: table => new
                {
                    IdTenant = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_tenant", x => x.IdTenant);
                });

            migrationBuilder.CreateTable(
                name: "ac_invoice_items",
                columns: table => new
                {
                    IdInvoiceItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: true),
                    IdProduct = table.Column<int>(nullable: true),
                    IdInvoice = table.Column<int>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    UnitValue = table.Column<float>(nullable: false),
                    ItemValue = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_invoice_items", x => x.IdInvoiceItem);
                    table.ForeignKey(
                        name: "FK_ac_invoice_items_ac_tenant_IdTenant",
                        column: x => x.IdTenant,
                        principalTable: "ac_tenant",
                        principalColumn: "IdTenant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ac_invoices",
                columns: table => new
                {
                    IdInvoice = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: true),
                    IdCustomer = table.Column<int>(nullable: true),
                    DocDate = table.Column<string>(nullable: true),
                    DocNumber = table.Column<string>(nullable: true),
                    TotalDiscount = table.Column<int>(nullable: false),
                    TotalTax = table.Column<int>(nullable: false),
                    TotalValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_invoices", x => x.IdInvoice);
                    table.ForeignKey(
                        name: "FK_ac_invoices_ac_tenant_IdTenant",
                        column: x => x.IdTenant,
                        principalTable: "ac_tenant",
                        principalColumn: "IdTenant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ac_products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ListPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_products", x => x.IdProduct);
                    table.ForeignKey(
                        name: "FK_ac_products_ac_tenant_IdTenant",
                        column: x => x.IdTenant,
                        principalTable: "ac_tenant",
                        principalColumn: "IdTenant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    IdCustomer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.IdCustomer);
                    table.ForeignKey(
                        name: "FK_customer_ac_tenant_IdTenant",
                        column: x => x.IdTenant,
                        principalTable: "ac_tenant",
                        principalColumn: "IdTenant",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ac_invoice_items_IdTenant",
                table: "ac_invoice_items",
                column: "IdTenant");

            migrationBuilder.CreateIndex(
                name: "IX_ac_invoices_IdTenant",
                table: "ac_invoices",
                column: "IdTenant");

            migrationBuilder.CreateIndex(
                name: "IX_ac_products_IdTenant",
                table: "ac_products",
                column: "IdTenant");

            migrationBuilder.CreateIndex(
                name: "IX_customer_IdTenant",
                table: "customer",
                column: "IdTenant");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ac_invoice_items");

            migrationBuilder.DropTable(
                name: "ac_invoices");

            migrationBuilder.DropTable(
                name: "ac_products");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "ac_tenant");
        }
    }
}
