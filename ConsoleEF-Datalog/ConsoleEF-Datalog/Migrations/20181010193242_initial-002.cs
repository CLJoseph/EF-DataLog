using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreRepositoryDatalog.Migrations
{
    public partial class initial002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewValue",
                table: "T_DBLog");

            migrationBuilder.RenameColumn(
                name: "OriginalValue",
                table: "T_DBLog",
                newName: "Detail");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "T_Person",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "T_Person",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "T_Person",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TableName",
                table: "T_DBLog",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Event",
                table: "T_DBLog",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_T_DBLog_LogDateTime",
                table: "T_DBLog",
                column: "LogDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_T_DBLog_LogDateTime",
                table: "T_DBLog");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "T_Person");

            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "T_DBLog",
                newName: "OriginalValue");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "T_Person",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "T_Person",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TableName",
                table: "T_DBLog",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Event",
                table: "T_DBLog",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NewValue",
                table: "T_DBLog",
                nullable: true);
        }
    }
}
