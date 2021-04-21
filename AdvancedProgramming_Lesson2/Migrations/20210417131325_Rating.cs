using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvancedProgramming_Lesson2.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("Producent", "Movie", nullable: true);

            migrationBuilder.AddColumn<string>("Rating","Movie", nullable: true);
            migrationBuilder.AddColumn<string>("nowa", "Movie", nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Producent", "Movie");

            migrationBuilder.DropColumn("Rating", "Movie");
            migrationBuilder.DropColumn("nowa", "Movie");
        }
    }
}
