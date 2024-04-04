using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FURNITURE.Migrations
{
    /// <inheritdoc />
    public partial class Chair : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SofaData",
                table: "SofaData");

            migrationBuilder.RenameTable(
                name: "SofaData",
                newName: "SofaDataModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SofaDataModel",
                table: "SofaDataModel",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SofaDataModel",
                table: "SofaDataModel");

            migrationBuilder.RenameTable(
                name: "SofaDataModel",
                newName: "SofaData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SofaData",
                table: "SofaData",
                column: "Id");
        }
    }
}
