using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveOptionalityInCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_ac_tenant_IdTenant",
                table: "customer");

            migrationBuilder.AlterColumn<int>(
                name: "IdTenant",
                table: "customer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_customer_ac_tenant_IdTenant",
                table: "customer",
                column: "IdTenant",
                principalTable: "ac_tenant",
                principalColumn: "IdTenant",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customer_ac_tenant_IdTenant",
                table: "customer");

            migrationBuilder.AlterColumn<int>(
                name: "IdTenant",
                table: "customer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_customer_ac_tenant_IdTenant",
                table: "customer",
                column: "IdTenant",
                principalTable: "ac_tenant",
                principalColumn: "IdTenant",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
