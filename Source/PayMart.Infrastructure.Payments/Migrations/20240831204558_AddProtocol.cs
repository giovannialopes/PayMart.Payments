using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayMart.Infrastructure.Payments.Migrations
{
    /// <inheritdoc />
    public partial class AddProtocol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Protocol",
                table: "Tb_Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Protocol",
                table: "Tb_Payment");
        }
    }
}
