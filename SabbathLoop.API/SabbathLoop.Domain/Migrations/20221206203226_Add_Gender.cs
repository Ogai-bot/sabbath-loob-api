using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabbathLoop.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "gender",
                schema: "dbo",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "gender",
                schema: "dbo",
                table: "members",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                schema: "dbo",
                table: "users");

            migrationBuilder.DropColumn(
                name: "gender",
                schema: "dbo",
                table: "members");
        }
    }
}
