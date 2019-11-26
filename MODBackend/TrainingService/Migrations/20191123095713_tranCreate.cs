using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingService.Migrations
{
    public partial class tranCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentordtl_MentorDtlMentorId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Userdtl_UserdtlUserId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_MentorDtlMentorId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UserdtlUserId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "MentorDtlMentorId",
                table: "Training");

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
                name: "UserdtlUserId",
                table: "Training");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Training",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "Training",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorId",
                table: "Training",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserId",
                table: "Training",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentordtl_MentorId",
                table: "Training",
                column: "MentorId",
                principalTable: "Mentordtl",
                principalColumn: "MentorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Userdtl_UserId",
                table: "Training",
                column: "UserId",
                principalTable: "Userdtl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentordtl_MentorId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Userdtl_UserId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_MentorId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UserId",
                table: "Training");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MentorId",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MentorDtlMentorId",
                table: "Training",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MentorName",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkillName",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserdtlUserId",
                table: "Training",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorDtlMentorId",
                table: "Training",
                column: "MentorDtlMentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserdtlUserId",
                table: "Training",
                column: "UserdtlUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentordtl_MentorDtlMentorId",
                table: "Training",
                column: "MentorDtlMentorId",
                principalTable: "Mentordtl",
                principalColumn: "MentorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Userdtl_UserdtlUserId",
                table: "Training",
                column: "UserdtlUserId",
                principalTable: "Userdtl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
