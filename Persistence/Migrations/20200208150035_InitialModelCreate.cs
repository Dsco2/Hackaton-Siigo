using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialModelCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTenant",
                table: "customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "customer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ac_invoice_items",
                columns: table => new
                {
                    IdInvoiceItem = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    IdInvoice = table.Column<int>(nullable: false),
                    Quantity = table.Column<float>(nullable: false),
                    UnitValue = table.Column<float>(nullable: false),
                    ItemValue = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_invoice_items", x => x.IdInvoiceItem);
                });

            migrationBuilder.CreateTable(
                name: "ac_invoices",
                columns: table => new
                {
                    IdInvoice = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: false),
                    IdCustomer = table.Column<int>(nullable: false),
                    DocDate = table.Column<string>(nullable: true),
                    DocNumber = table.Column<string>(nullable: true),
                    TotalDiscount = table.Column<int>(nullable: false),
                    TotalTax = table.Column<int>(nullable: false),
                    TotalValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_invoices", x => x.IdInvoice);
                });

            migrationBuilder.CreateTable(
                name: "ac_products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTenant = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ListPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ac_products", x => x.IdProduct);
                });

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
                name: "ac_tenant");

            migrationBuilder.DropColumn(
                name: "IdTenant",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "customer");
        }
    }
}
