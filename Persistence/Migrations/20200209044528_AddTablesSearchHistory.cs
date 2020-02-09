using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTablesSearchHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "search_customer_history",
                columns: table => new
                {
                    IdSearchCustomerHistory = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCustomer = table.Column<int>(nullable: false),
                    AmountOfSearch = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_search_customer_history", x => x.IdSearchCustomerHistory);
                    table.ForeignKey(
                        name: "FK_search_customer_history_customer_IdCustomer",
                        column: x => x.IdCustomer,
                        principalTable: "customer",
                        principalColumn: "IdCustomer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "search_history",
                columns: table => new
                {
                    IdSearchProductHistory = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdProduct = table.Column<int>(nullable: false),
                    AmountOfSearch = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_search_history", x => x.IdSearchProductHistory);
                    table.ForeignKey(
                        name: "FK_search_history_ac_products_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "ac_products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_search_customer_history_IdCustomer",
                table: "search_customer_history",
                column: "IdCustomer");

            migrationBuilder.CreateIndex(
                name: "IX_search_history_IdProduct",
                table: "search_history",
                column: "IdProduct");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "search_customer_history");

            migrationBuilder.DropTable(
                name: "search_history");
        }
    }
}
