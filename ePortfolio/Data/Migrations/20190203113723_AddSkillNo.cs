using Microsoft.EntityFrameworkCore.Migrations;

namespace ePortfolio.Data.Migrations
{
    public partial class AddSkillNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillNo",
                table: "Skills",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillNo",
                table: "Skills");
        }
    }
}
