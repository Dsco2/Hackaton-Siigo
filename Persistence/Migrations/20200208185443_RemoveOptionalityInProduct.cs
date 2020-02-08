using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveOptionalityInProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ac_products_ac_tenant_IdTenant",
                table: "ac_products");

            migrationBuilder.AlterColumn<int>(
                name: "IdTenant",
                table: "ac_products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ac_products_ac_tenant_IdTenant",
                table: "ac_products",
                column: "IdTenant",
                principalTable: "ac_tenant",
                principalColumn: "IdTenant",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ac_products_ac_tenant_IdTenant",
                table: "ac_products");

            migrationBuilder.AlterColumn<int>(
                name: "IdTenant",
                table: "ac_products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ac_products_ac_tenant_IdTenant",
                table: "ac_products",
                column: "IdTenant",
                principalTable: "ac_tenant",
                principalColumn: "IdTenant",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
