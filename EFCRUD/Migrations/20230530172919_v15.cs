using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCRUD.Migrations
{
    /// <inheritdoc />
    public partial class v15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Catlogs_CatalogId",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogId",
                table: "News",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_News_Catlogs_CatalogId",
                table: "News",
                column: "CatalogId",
                principalTable: "Catlogs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_Catlogs_CatalogId",
                table: "News");

            migrationBuilder.AlterColumn<int>(
                name: "CatalogId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Catlogs_CatalogId",
                table: "News",
                column: "CatalogId",
                principalTable: "Catlogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
