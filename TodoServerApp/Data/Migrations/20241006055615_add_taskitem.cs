using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishTDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItems",
                columns: new[] { "Id", "CreateTDate", "Description", "FinishTDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1231), "Описание задачи 1", null, "Задача 1" },
                    { 2, new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1244), "Описание задачи 2", null, "Задача 2" },
                    { 3, new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1245), "Описание задачи 3", null, "Задача 3" },
                    { 4, new DateTime(2024, 10, 6, 10, 56, 14, 795, DateTimeKind.Local).AddTicks(1246), "Описание задачи 4", null, "Задача 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItems");
        }
    }
}
