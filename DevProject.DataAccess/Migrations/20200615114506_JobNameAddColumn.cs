using Microsoft.EntityFrameworkCore.Migrations;

namespace DevProject.DataAccess.Migrations
{
    public partial class JobNameAddColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Jobs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Jobs");
        }
    }
}
