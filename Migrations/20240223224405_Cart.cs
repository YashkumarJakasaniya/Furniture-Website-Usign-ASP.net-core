using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FURNITURE.Migrations
{
    /// <inheritdoc />
    public partial class Cart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChairData",
                table: "ChairData");

            migrationBuilder.RenameTable(
                name: "ChairData",
                newName: "Chairtbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Chairtbl",
                table: "Chairtbl",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CartData",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartData", x => x.ProductId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Chairtbl",
                table: "Chairtbl");

            migrationBuilder.RenameTable(
                name: "Chairtbl",
                newName: "ChairData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChairData",
                table: "ChairData",
                column: "Id");
        }
    }
}
