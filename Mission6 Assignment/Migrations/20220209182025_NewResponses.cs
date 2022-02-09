using Microsoft.EntityFrameworkCore.Migrations;

namespace mission6.Migrations
{
    public partial class NewResponses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewResponses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Task = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewResponses", x => x.ApplicationId);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TaskID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TaskName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TaskID);
                });

            migrationBuilder.InsertData(
                table: "NewResponses",
                columns: new[] { "ApplicationId", "Task" },
                values: new object[] { 1, "IS Homework" });

            migrationBuilder.InsertData(
                table: "NewResponses",
                columns: new[] { "ApplicationId", "Task" },
                values: new object[] { 2, "Spending time with wife" });

            migrationBuilder.InsertData(
                table: "NewResponses",
                columns: new[] { "ApplicationId", "Task" },
                values: new object[] { 3, "Intern" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewResponses");

            migrationBuilder.DropTable(
                name: "Task");
        }
    }
}
