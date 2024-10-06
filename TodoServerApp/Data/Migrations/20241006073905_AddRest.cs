using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 12, 39, 5, 463, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 12, 39, 5, 463, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 12, 39, 5, 463, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 12, 39, 5, 463, DateTimeKind.Local).AddTicks(835));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTDate",
                value: new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1246));
        }
    }
}
