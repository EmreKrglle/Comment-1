using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.Migrations
{
    /// <inheritdoc />
    public partial class migration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "username",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "name_id",
                table: "Task",
                newName: "title");

            migrationBuilder.AddColumn<bool>(
                name: "completed",
                table: "Task",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Task",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "completed",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Task");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Task",
                newName: "name_id");

            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "Task",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
