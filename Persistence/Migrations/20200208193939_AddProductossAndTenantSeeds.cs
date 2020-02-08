using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddProductossAndTenantSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ac_tenant",
                columns: new[] { "IdTenant", "Name", "Theme" },
                values: new object[] { 1, "Exito", "warning" });

            migrationBuilder.InsertData(
                table: "ac_tenant",
                columns: new[] { "IdTenant", "Name", "Theme" },
                values: new object[] { 2, "Jumbo", "primary" });

            migrationBuilder.InsertData(
                table: "ac_tenant",
                columns: new[] { "IdTenant", "Name", "Theme" },
                values: new object[] { 3, "Cueros SAS", "info" });

            migrationBuilder.InsertData(
                table: "ac_products",
                columns: new[] { "IdProduct", "Description", "IdTenant", "ListPrice", "Name" },
                values: new object[,]
                {
                    { 9, "Rice", 1, 65464f, "Rice" },
                    { 10, "Beens", 1, 6554654f, "Beens" },
                    { 11, "Clothes", 1, 6546f, "Clothes" },
                    { 12, "Meat", 1, 65465f, "Meat" },
                    { 5, "Fresh Potatoes", 2, 15616f, "Potatoes" },
                    { 6, "Fresh Tomatoes", 2, 65464f, "Tomatoes" },
                    { 7, "Fresh Pineaples", 2, 4468f, "Pineaples" },
                    { 8, "Fresh Onions", 2, 114f, "Onions" },
                    { 1, "Lether wallet", 3, 100000f, "wallet" },
                    { 2, "Lether Shoes", 3, 75000f, "Shoes" },
                    { 3, "Lether Jacket", 3, 350000f, "Jacket" },
                    { 4, "Lether Hat", 3, 200000f, "Hat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ac_tenant",
                keyColumn: "IdTenant",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ac_tenant",
                keyColumn: "IdTenant",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ac_tenant",
                keyColumn: "IdTenant",
                keyValue: 3);
        }
    }
}
