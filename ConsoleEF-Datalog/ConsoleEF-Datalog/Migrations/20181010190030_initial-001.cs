using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreRepositoryDatalog.Migrations
{
    public partial class initial001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_DBLog",
                columns: table => new
                {
                    ID = table.Column<Guid>(maxLength: 40, nullable: false),
                    LogDateTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Device = table.Column<string>(nullable: true),
                    TableName = table.Column<string>(nullable: true),
                    Event = table.Column<string>(nullable: true),
                    OriginalValue = table.Column<string>(nullable: true),
                    NewValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DBLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Lookup",
                columns: table => new
                {
                    ID = table.Column<Guid>(maxLength: 40, nullable: false),
                    Lookup = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Lookup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Person",
                columns: table => new
                {
                    ID = table.Column<Guid>(maxLength: 40, nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Person", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Address",
                columns: table => new
                {
                    ID = table.Column<Guid>(maxLength: 40, nullable: false),
                    Line001 = table.Column<string>(maxLength: 50, nullable: true),
                    Line002 = table.Column<string>(maxLength: 50, nullable: true),
                    Line003 = table.Column<string>(maxLength: 50, nullable: true),
                    Line004 = table.Column<string>(maxLength: 50, nullable: true),
                    Line005 = table.Column<string>(maxLength: 50, nullable: true),
                    Code = table.Column<string>(maxLength: 12, nullable: true),
                    T_PersonID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Address", x => x.ID);
                    table.ForeignKey(
                        name: "FK_T_Address_T_Person_T_PersonID",
                        column: x => x.T_PersonID,
                        principalTable: "T_Person",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_Address_T_PersonID",
                table: "T_Address",
                column: "T_PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Address");

            migrationBuilder.DropTable(
                name: "T_DBLog");

            migrationBuilder.DropTable(
                name: "T_Lookup");

            migrationBuilder.DropTable(
                name: "T_Person");
        }
    }
}
