using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudyProject.Todo.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Guid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Guid);
                });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Guid", "IsComplete", "Name" },
                values: new object[,]
                {
                    { new Guid("f6c8ef7e-9650-47a9-8fac-091733374b90"), true, "name1" },
                    { new Guid("9cf69362-6575-4178-b593-d2baf34ec1f8"), false, "name2" },
                    { new Guid("e590b122-eab2-422d-944b-3324d664eddc"), true, "name3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems");
        }
    }
}
