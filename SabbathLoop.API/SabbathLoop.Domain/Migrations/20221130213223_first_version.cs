using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SabbathLoop.Domain.Migrations
{
    /// <inheritdoc />
    public partial class firstversion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "churches",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_churches", x => x.id);
                    table.ForeignKey(
                        name: "FK_churches_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "members",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "varchar(200)", nullable: false),
                    email = table.Column<string>(type: "varchar(200)", nullable: false),
                    password = table.Column<string>(type: "varchar(200)", nullable: false),
                    asknewpassword = table.Column<bool>(name: "ask_new_password", type: "bit", nullable: false, defaultValueSql: "0"),
                    hasconfirmedemail = table.Column<bool>(name: "has_confirmed_email", type: "bit", nullable: false, defaultValueSql: "0"),
                    termsacceptancedate = table.Column<DateTimeOffset>(name: "terms_acceptance_date", type: "datetimeoffset", nullable: false),
                    termsacceptanceip = table.Column<string>(name: "terms_acceptance_ip", type: "varchar(20)", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.id);
                    table.ForeignKey(
                        name: "FK_members_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "quarters",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    startdate = table.Column<DateTimeOffset>(name: "start_date", type: "datetimeoffset", nullable: false),
                    enddate = table.Column<DateTimeOffset>(name: "end_date", type: "datetimeoffset", nullable: false),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quarters", x => x.id);
                    table.ForeignKey(
                        name: "FK_quarters_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "varchar(200)", nullable: false),
                    email = table.Column<string>(type: "varchar(200)", nullable: false),
                    password = table.Column<string>(type: "varchar(200)", nullable: false),
                    asknewpassword = table.Column<bool>(name: "ask_new_password", type: "bit", nullable: false, defaultValueSql: "0"),
                    hasconfirmedemail = table.Column<bool>(name: "has_confirmed_email", type: "bit", nullable: false, defaultValueSql: "0"),
                    termsacceptancedate = table.Column<DateTimeOffset>(name: "terms_acceptance_date", type: "datetimeoffset", nullable: false),
                    termsacceptanceip = table.Column<string>(name: "terms_acceptance_ip", type: "varchar(20)", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "classes",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    name = table.Column<string>(type: "varchar(100)", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    churchid = table.Column<Guid>(name: "church_id", type: "uniqueidentifier", nullable: false),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes", x => x.id);
                    table.ForeignKey(
                        name: "FK_classes_church_id",
                        column: x => x.churchid,
                        principalSchema: "dbo",
                        principalTable: "churches",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_classes_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "responses",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    memberid = table.Column<Guid>(name: "member_id", type: "uniqueidentifier", nullable: false),
                    classid = table.Column<Guid>(name: "class_id", type: "uniqueidentifier", nullable: false),
                    churchid = table.Column<Guid>(name: "church_id", type: "uniqueidentifier", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    waspresent = table.Column<bool>(name: "was_present", type: "bit", nullable: false, defaultValueSql: "0"),
                    dailycommunion = table.Column<bool>(name: "daily_communion", type: "bit", nullable: false, defaultValueSql: "0"),
                    helpedsomeone = table.Column<bool>(name: "helped_someone", type: "bit", nullable: false, defaultValueSql: "0"),
                    talkedaboutgod = table.Column<bool>(name: "talked_about_god", type: "bit", nullable: false, defaultValueSql: "0"),
                    teachingsomeone = table.Column<bool>(name: "teaching_someone", type: "bit", nullable: false, defaultValueSql: "0"),
                    baptizedsomeonethisyear = table.Column<bool>(name: "baptized_someone_this_year", type: "bit", nullable: false, defaultValueSql: "0"),
                    disciplesomeone = table.Column<bool>(name: "disciple_someone", type: "bit", nullable: false, defaultValueSql: "0"),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.id);
                    table.ForeignKey(
                        name: "FK_responses_church_id",
                        column: x => x.churchid,
                        principalSchema: "dbo",
                        principalTable: "churches",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_responses_class_id",
                        column: x => x.classid,
                        principalSchema: "dbo",
                        principalTable: "classes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_responses_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_responses_member_id",
                        column: x => x.memberid,
                        principalSchema: "dbo",
                        principalTable: "members",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "user_access_classes",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    userid = table.Column<Guid>(name: "user_id", type: "uniqueidentifier", nullable: false),
                    classid = table.Column<Guid>(name: "class_id", type: "uniqueidentifier", nullable: false),
                    companyid = table.Column<Guid>(name: "company_id", type: "uniqueidentifier", nullable: false),
                    hasaccess = table.Column<bool>(name: "has_access", type: "bit", nullable: false, defaultValueSql: "0"),
                    lastmodified = table.Column<DateTimeOffset>(name: "last_modified", type: "datetimeoffset", nullable: true),
                    creationdate = table.Column<DateTimeOffset>(name: "creation_date", type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    removed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_access_classes", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_access_classes_class_id",
                        column: x => x.classid,
                        principalSchema: "dbo",
                        principalTable: "classes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_access_classes_company_id",
                        column: x => x.companyid,
                        principalSchema: "dbo",
                        principalTable: "companies",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_user_access_classes_user_id",
                        column: x => x.userid,
                        principalSchema: "dbo",
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_churches_company_id",
                schema: "dbo",
                table: "churches",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_classes_church_id",
                schema: "dbo",
                table: "classes",
                column: "church_id");

            migrationBuilder.CreateIndex(
                name: "IX_classes_company_id",
                schema: "dbo",
                table: "classes",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_members_company_id",
                schema: "dbo",
                table: "members",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_quarters_company_id",
                schema: "dbo",
                table: "quarters",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_responses_church_id",
                schema: "dbo",
                table: "responses",
                column: "church_id");

            migrationBuilder.CreateIndex(
                name: "IX_responses_class_id",
                schema: "dbo",
                table: "responses",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_responses_company_id",
                schema: "dbo",
                table: "responses",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_responses_member_id",
                schema: "dbo",
                table: "responses",
                column: "member_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_access_classes_class_id",
                schema: "dbo",
                table: "user_access_classes",
                column: "class_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_access_classes_company_id",
                schema: "dbo",
                table: "user_access_classes",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_access_classes_user_id",
                schema: "dbo",
                table: "user_access_classes",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_company_id",
                schema: "dbo",
                table: "users",
                column: "company_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "quarters",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "responses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "user_access_classes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "members",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "classes",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "churches",
                schema: "dbo");
        }
    }
}
