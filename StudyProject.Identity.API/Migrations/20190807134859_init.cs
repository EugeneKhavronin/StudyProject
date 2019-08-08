using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyProject.Identity.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Guid", "Login", "Password" },
                values: new object[,]
                {
                    { new Guid("af81e6f7-42dd-42e8-83f1-bd5a8fd4c6e5"), "admin@gmail.com", "AQAAAAEAACcQAAAAECaPpK4il2VcAuvlKCjAOF3L/7PKpFVheMkMfw2xdgnDX6GHAh5Py0gdTgx9kpN7SQ==" },
                    { new Guid("88eda3d7-edb2-434c-b781-95aeeadcdc89"), "qwerty", "AQAAAAEAACcQAAAAEA7WMtKRrPVg4avuUaFoOXg2bc3QfDJOIH3GgFtenYsjZWSEYlsjpkqapzRpw56EbA==" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
