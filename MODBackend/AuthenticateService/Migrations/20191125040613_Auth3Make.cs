using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthenticateService.Migrations
{
    public partial class Auth3Make : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "amount",
                table: "Paymentdtl",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "AmountToMentor",
                table: "Paymentdtl",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "amount",
                table: "Paymentdtl",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "AmountToMentor",
                table: "Paymentdtl",
                type: "float",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
