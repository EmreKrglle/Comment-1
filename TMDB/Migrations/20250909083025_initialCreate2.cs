using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TMDB.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "favorite_count",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "friend_count",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "rated_count",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "watch_count",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "body");

            migrationBuilder.AddColumn<int>(
                name: "name_id",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name_id",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "body",
                table: "Users",
                newName: "name");

            migrationBuilder.AddColumn<int>(
                name: "favorite_count",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "friend_count",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rated_count",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "watch_count",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}
