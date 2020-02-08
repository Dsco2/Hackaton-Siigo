using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ac_invoices_IdCustomer",
                table: "ac_invoices",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_ac_invoice_items_IdInvoice",
                table: "ac_invoice_items",
                column: "IdInvoice");

            migrationBuilder.CreateIndex(
                name: "IX_ac_invoice_items_IdProduct",
                table: "ac_invoice_items",
                column: "IdProduct");

            migrationBuilder.AddForeignKey(
                name: "FK_ac_invoice_items_ac_invoices_IdInvoice",
                table: "ac_invoice_items",
                column: "IdInvoice",
                principalTable: "ac_invoices",
                principalColumn: "IdInvoice",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ac_invoice_items_ac_products_IdProduct",
                table: "ac_invoice_items",
                column: "IdProduct",
                principalTable: "ac_products",
                principalColumn: "IdProduct",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ac_invoices_customer_IdCustomer",
                table: "ac_invoices",
                column: "IdCustomer",
                principalTable: "customer",
                principalColumn: "IdCustomer",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ac_invoice_items_ac_invoices_IdInvoice",
                table: "ac_invoice_items");

            migrationBuilder.DropForeignKey(
                name: "FK_ac_invoice_items_ac_products_IdProduct",
                table: "ac_invoice_items");

            migrationBuilder.DropForeignKey(
                name: "FK_ac_invoices_customer_IdCustomer",
                table: "ac_invoices");

            migrationBuilder.DropIndex(
                name: "IX_ac_invoices_IdCustomer",
                table: "ac_invoices");

            migrationBuilder.DropIndex(
                name: "IX_ac_invoice_items_IdInvoice",
                table: "ac_invoice_items");

            migrationBuilder.DropIndex(
                name: "IX_ac_invoice_items_IdProduct",
                table: "ac_invoice_items");
        }
    }
}
