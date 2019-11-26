using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingService.Migrations
{
    public partial class UserCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SkillId",
                table: "Training",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MentorDtlMentorId",
                table: "Training",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserdtlUserId",
                table: "Training",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Mentordtl",
                columns: table => new
                {
                    MentorId = table.Column<string>(nullable: false),
                    MentorName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    ContactNo = table.Column<string>(maxLength: 10, nullable: true),
                    Password = table.Column<string>(maxLength: 5, nullable: false),
                    TimeSlot = table.Column<string>(nullable: true),
                    YearsOfExperience = table.Column<int>(nullable: true),
                    Facilities = table.Column<string>(nullable: true),
                    Technologies = table.Column<string>(nullable: true),
                    linkedInUrl = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentordtl", x => x.MentorId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<string>(nullable: false),
                    SkillName = table.Column<string>(nullable: true),
                    toc = table.Column<string>(nullable: true),
                    prerequisites = table.Column<string>(nullable: true),
                    fees = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Userdtl",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 5, nullable: false),
                    ContactNo = table.Column<string>(maxLength: 10, nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Active = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userdtl", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Paymentdtl",
                columns: table => new
                {
                    PaymentId = table.Column<string>(nullable: false),
                    amount = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    MentorId = table.Column<string>(nullable: true),
                    TrainingId = table.Column<string>(nullable: true),
                    AmountToMentor = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paymentdtl", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Paymentdtl_Mentordtl_MentorId",
                        column: x => x.MentorId,
                        principalTable: "Mentordtl",
                        principalColumn: "MentorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paymentdtl_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "TrainingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Paymentdtl_Userdtl_UserId",
                        column: x => x.UserId,
                        principalTable: "Userdtl",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Training_MentorDtlMentorId",
                table: "Training",
                column: "MentorDtlMentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_SkillId",
                table: "Training",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_UserdtlUserId",
                table: "Training",
                column: "UserdtlUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_MentorId",
                table: "Paymentdtl",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_TrainingId",
                table: "Paymentdtl",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_Paymentdtl_UserId",
                table: "Paymentdtl",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Mentordtl_MentorDtlMentorId",
                table: "Training",
                column: "MentorDtlMentorId",
                principalTable: "Mentordtl",
                principalColumn: "MentorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Skill_SkillId",
                table: "Training",
                column: "SkillId",
                principalTable: "Skill",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Training_Userdtl_UserdtlUserId",
                table: "Training",
                column: "UserdtlUserId",
                principalTable: "Userdtl",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Training_Mentordtl_MentorDtlMentorId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Skill_SkillId",
                table: "Training");

            migrationBuilder.DropForeignKey(
                name: "FK_Training_Userdtl_UserdtlUserId",
                table: "Training");

            migrationBuilder.DropTable(
                name: "Paymentdtl");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Mentordtl");

            migrationBuilder.DropTable(
                name: "Userdtl");

            migrationBuilder.DropIndex(
                name: "IX_Training_MentorDtlMentorId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_SkillId",
                table: "Training");

            migrationBuilder.DropIndex(
                name: "IX_Training_UserdtlUserId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "MentorDtlMentorId",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "UserdtlUserId",
                table: "Training");

            migrationBuilder.AlterColumn<string>(
                name: "SkillId",
                table: "Training",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
