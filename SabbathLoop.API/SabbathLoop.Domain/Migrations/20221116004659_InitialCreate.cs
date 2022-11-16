using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabbathLoop.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "companies",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "companies",
                schema: "dbo");
        }
    }
}
