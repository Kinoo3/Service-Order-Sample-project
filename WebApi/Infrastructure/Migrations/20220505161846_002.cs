using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Infrastructure.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Entity2Id",
                table: "Entity1s",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Teste2",
                table: "Entity1s",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Entity1s_Entity2Id",
                table: "Entity1s",
                column: "Entity2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entity1s_Entity2s_Entity2Id",
                table: "Entity1s",
                column: "Entity2Id",
                principalTable: "Entity2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entity1s_Entity2s_Entity2Id",
                table: "Entity1s");

            migrationBuilder.DropIndex(
                name: "IX_Entity1s_Entity2Id",
                table: "Entity1s");

            migrationBuilder.DropColumn(
                name: "Entity2Id",
                table: "Entity1s");

            migrationBuilder.DropColumn(
                name: "Teste2",
                table: "Entity1s");
        }
    }
}
