using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQList.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 2, "History" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 5,
                column: "CategoryType",
                value: "History");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 4,
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 1, "General" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "QuestionID",
                keyValue: 5,
                column: "CategoryType",
                value: "General");
        }
    }
}
