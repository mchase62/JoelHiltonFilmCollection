using Microsoft.EntityFrameworkCore.Migrations;

namespace JoelHiltonFilmCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.FormId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Science Fiction", "George Lucas", false, null, null, "PG-13", "A New Hope", 1978 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Science Fiction", "Irvin Kershner", false, null, null, "PG-13", "The Empire Strikes Back", 1980 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "FormId", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Science Fiction", "Richard Marquand", false, null, null, "PG-13", "Return of the Jedi", 1983 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
