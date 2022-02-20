using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InteractiveMap.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AuthorFirstName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AuthorLastName",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorFirstName",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AuthorLastName",
                table: "Comments");

            migrationBuilder.AddColumn<int>(
                name: "CommentId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
