using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoApp.Migrations
{
    public partial class TodoListAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Assignment", true });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Cleaning", true });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Make food", false });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Play basketball", true });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Shopping", false });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Title", "IsCompleted" },
                values: new object[] { "Workout", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Todo");
        }
    }
}
