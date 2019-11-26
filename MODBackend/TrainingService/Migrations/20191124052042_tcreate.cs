using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingService.Migrations
{
    public partial class tcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duration",
                table: "Training");

            migrationBuilder.AddColumn<int>(
                name: "duration",
                table: "Skill",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duration",
                table: "Skill");

            migrationBuilder.AddColumn<string>(
                name: "duration",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
