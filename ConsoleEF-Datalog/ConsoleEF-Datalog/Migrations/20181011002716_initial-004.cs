using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreRepositoryDatalog.Migrations
{
    public partial class initial004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TableForeignKeys",
                table: "T_DBLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableForeignKeys",
                table: "T_DBLog");
        }
    }
}
