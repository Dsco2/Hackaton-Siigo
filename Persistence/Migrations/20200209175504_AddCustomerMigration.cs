using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddCustomerMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "customer",
                columns: new[] { "IdCustomer", "FirstName", "IdTenant", "LastName" },
                values: new object[,]
                {
                    { 1, "Daniel", 3, "Cantor" },
                    { 18, "Sofia", 3, "Rodriguez" },
                    { 17, "Laura", 3, "Gonzalez" },
                    { 16, "Alberto", 3, "Gomez" },
                    { 15, "Enrique", 3, "Saenz" },
                    { 14, "Carlos", 3, "Rubiano" },
                    { 13, "Maria", 3, "Suarez" },
                    { 12, "Ana", 3, "Cepeda" },
                    { 11, "Sofia", 3, "Robledo" },
                    { 10, "Juan", 3, "Santos" },
                    { 9, "Santiago", 3, "Jimenez" },
                    { 8, "Andres", 3, "Robledo" },
                    { 7, "Diego", 3, "Ortiz" },
                    { 6, "Carolina", 3, "Uribe" },
                    { 5, "Felipe", 3, "Rodriguez" },
                    { 4, "Jessica", 3, "Gonzalez" },
                    { 3, "Ricardo", 3, "Gomez" },
                    { 2, "Jorge", 3, "Nuñez" },
                    { 19, "Ana", 3, "Uribe" },
                    { 20, "Maria", 3, "Ortiz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "customer",
                keyColumn: "IdCustomer",
                keyValue: 20);
        }
    }
}
