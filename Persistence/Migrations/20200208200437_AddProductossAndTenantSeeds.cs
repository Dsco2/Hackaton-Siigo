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
                    { 20, "Leche marca Exito", 1, 56454f, "Leche" },
                    { 9, "Chaqueta artesanal de cuero", 3, 350006f, "Chaqueta artesanal" },
                    { 8, "Chaqueta importada de cuero", 3, 350005f, "Chaqueta importada" },
                    { 7, "Chaqueta tipo motociclista de cuero", 3, 350004f, "Chaqueta tipo motociclista" },
                    { 6, "Sombreros para mujer de cuero", 3, 350003f, "Sombreros para mujer" },
                    { 5, "Sombreros para hombre de cuero", 3, 350002f, "Sombreros para hombre" },
                    { 4, "Billetera importada de cuero", 3, 350001f, "Billetera importada" },
                    { 3, "Biiletera gris de cuero", 3, 350000f, "Biiletera gris" },
                    { 2, "Billeteras artesanales de cuero", 3, 75000f, "Billeteras artesanales" },
                    { 1, "Billetera negra de cuero", 3, 100000f, "Billetera negra" },
                    { 19, "Cebollas marca Jumbo", 2, 114f, "Cebollas" },
                    { 18, "Piñas marca Jumbo", 2, 4468f, "Piñas" },
                    { 17, "Tomates marca Jumbo", 2, 65464f, "Tomates" },
                    { 16, "Papas  marca Jumbo", 2, 15616f, "Papas " },
                    { 10, "Chaqueta  de cuero", 3, 350007f, "Chaqueta " },
                    { 15, "Papas fritas marca Jumbo", 2, 64554f, "Papas fritas" },
                    { 13, "Papa sabadera marca Jumbo", 2, 45645f, "Papa sabadera" },
                    { 12, "Papa criolla marca Jumbo", 2, 5646f, "Papa criolla" },
                    { 31, "Carnes congeladas marca Exito", 1, 65465f, "Carnes congeladas" },
                    { 30, "Ropa formal marca Exito", 1, 6546f, "Ropa formal" },
                    { 29, "Frijol marca Exito", 1, 6554654f, "Frijol" },
                    { 28, "Arroz marca Exito", 1, 65464f, "Arroz" },
                    { 27, "Ropa informal marca Exito", 1, 2156f, "Ropa informal" },
                    { 26, "Arroz integral marca Exito", 1, 8785f, "Arroz integral" },
                    { 25, "Leche de soja marca Exito", 1, 5456f, "Leche de soja" },
                    { 24, "Leche de almendras marca Exito", 1, 5454f, "Leche de almendras" },
                    { 23, "Leche descremada marca Exito", 1, 45655f, "Leche descremada" },
                    { 22, "Leche deslactosada marca Exito", 1, 654654f, "Leche deslactosada" },
                    { 21, "Leche entera marca Exito", 1, 100000f, "Leche entera" },
                    { 14, "Papa importada marca Jumbo", 2, 3546f, "Papa importada" },
                    { 11, "Sombrero importado de cuero", 3, 200000f, "Sombrero importado" }
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
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ac_products",
                keyColumn: "IdProduct",
                keyValue: 31);

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
