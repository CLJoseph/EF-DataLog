using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreRepositoryDatalog.Migrations
{
    public partial class initial003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TablePKName",
                table: "T_DBLog",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TablePKValue",
                table: "T_DBLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TablePKName",
                table: "T_DBLog");

            migrationBuilder.DropColumn(
                name: "TablePKValue",
                table: "T_DBLog");
        }
    }
}
