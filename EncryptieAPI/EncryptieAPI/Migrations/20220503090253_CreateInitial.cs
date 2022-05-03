using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EncryptieAPI.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Berichten",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    encryptedBericht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vervalDatum = table.Column<int>(type: "int", nullable: false),
                    aanmaakDatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isVervalt = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Berichten", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Berichten");
        }
    }
}
