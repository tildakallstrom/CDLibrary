using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appmom3.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TimeStamp",
                table: "Borrow",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Borrow",
                newName: "TimeStamp");
        }
    }
}
