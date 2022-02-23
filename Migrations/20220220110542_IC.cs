using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appmom3.Migrations
{
    public partial class IC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Cd");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Artist",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Artist");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Cd",
                type: "TEXT",
                nullable: true);
        }
    }
}
