using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayMart.Infrastructure.Payments.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Tb_Payment",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Tb_Payment",
                newName: "AmountPaid");

            migrationBuilder.RenameColumn(
                name: "PaymentType",
                table: "Tb_Payment",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Tb_Payment",
                newName: "PaymentDate");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Tb_Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tb_Payment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeleteBy",
                table: "Tb_Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentMethod",
                table: "Tb_Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Tb_Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Tb_Payment",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tb_Payment");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tb_Payment");

            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Tb_Payment");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Tb_Payment");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tb_Payment");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Tb_Payment");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Tb_Payment",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Tb_Payment",
                newName: "PaymentType");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "Tb_Payment",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "AmountPaid",
                table: "Tb_Payment",
                newName: "Price");
        }
    }
}
