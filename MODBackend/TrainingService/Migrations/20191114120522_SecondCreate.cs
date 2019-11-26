using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingService.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MentorName",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillName",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "endDate",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "paymentStatus",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "rejectNotify",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "requested",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "startDate",
                table: "Training",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MentorName",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "SkillName",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "endDate",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "paymentStatus",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "rejectNotify",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "requested",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "startDate",
                table: "Training");
        }
    }
}
