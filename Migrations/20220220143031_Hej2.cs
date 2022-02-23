using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace appmom3.Migrations
{
    public partial class Hej2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Borrow_CdId",
                table: "Borrow");

            migrationBuilder.CreateIndex(
                name: "IX_Borrow_CdId",
                table: "Borrow",
                column: "CdId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Borrow_CdId",
                table: "Borrow");

            migrationBuilder.CreateIndex(
                name: "IX_Borrow_CdId",
                table: "Borrow",
                column: "CdId");
        }
    }
}
