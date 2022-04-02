using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionMSG = table.Column<string>(nullable: true),
                    TopicType = table.Column<string>(nullable: true),
                    TopicID = table.Column<int>(nullable: false),
                    CategoryType = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "CategoryID", "CategoryType", "QuestionMSG", "TopicID", "TopicType" },
                values: new object[,]
                {
                    { 1, 1, "General", "What is Bootstrap? - A CSS Framework for creating responsive web apps for multiple screen sizes", 1, "Bootstrap" },
                    { 2, 2, "General", "What is C#? - a general purpose object oriented language that uses a concise java like syntax", 2, "C#" },
                    { 3, 3, "General", "What is javascript?- a general purpose scripting language that executes in a web browser", 3, "Javascript" },
                    { 4, 1, "General", "When was bootstrap released ? - 2011", 1, "Bootstrap" },
                    { 5, 2, "General", "When was C# released? - 2002", 2, "C#" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
