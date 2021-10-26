using Microsoft.EntityFrameworkCore.Migrations;

namespace ECBATS.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CryptoName = table.Column<string>(type: "TEXT", nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<string>(type: "TEXT", nullable: true),
                    Percent24h = table.Column<string>(type: "TEXT", nullable: true),
                    Percent7j = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { 1001L, "Laptop", "50%", null, "20.02", "10" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { 1002L, "Microsoft Office", "20%", null, "20.99", "50" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { 1003L, "Lazer Mouse", "3%", null, "12.02", "20" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CryptoName", "Percent24h", "Percent7j", "Price", "Symbol" },
                values: new object[] { 1004L, "USB Storage", "95%", null, "5.00", "20" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
