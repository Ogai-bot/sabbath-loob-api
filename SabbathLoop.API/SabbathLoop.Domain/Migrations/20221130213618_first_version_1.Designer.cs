﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SabbathLoop.Domain.Commands;

#nullable disable

namespace SabbathLoop.Domain.Migrations
{
    [DbContext(typeof(CommandDbContext))]
    [Migration("20221130213618_first_version_1")]
    partial class firstversion1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .UseCollation("latin1_general_ci_ai")
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Churches.Entities.Church", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.HasKey("Id")
                        .HasName("PK_churches");

                    b.HasIndex("CompanyId");

                    b.ToTable("churches", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Classes.Entities.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("ChurchId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("church_id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.HasKey("Id")
                        .HasName("PK_classes");

                    b.HasIndex("ChurchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("classes", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Companies.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.HasKey("Id")
                        .HasName("PK_companies");

                    b.ToTable("companies", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Members.Entities.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("AskNewPassword")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("ask_new_password")
                        .HasDefaultValueSql("0");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email");

                    b.Property<bool>("HasConfirmedEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("has_confirmed_email")
                        .HasDefaultValueSql("0");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("password");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.Property<DateTimeOffset>("TermsAcceptanceDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("terms_acceptance_date");

                    b.Property<string>("TermsAcceptanceIp")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("terms_acceptance_ip");

                    b.HasKey("Id")
                        .HasName("PK_members");

                    b.HasIndex("CompanyId");

                    b.ToTable("members", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Quarters.Entities.Quarter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("end_date");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("start_date");

                    b.HasKey("Id")
                        .HasName("PK_quarters");

                    b.HasIndex("CompanyId");

                    b.ToTable("quarters", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Responses.Entities.Response", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("BaptizedSomeoneThisYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("baptized_someone_this_year")
                        .HasDefaultValueSql("0");

                    b.Property<Guid>("ChurchId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("church_id");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<bool>("DailyCommunion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("daily_communion")
                        .HasDefaultValueSql("0");

                    b.Property<bool>("DiscipleSomeone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("disciple_someone")
                        .HasDefaultValueSql("0");

                    b.Property<bool>("HelpedSomeone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("helped_someone")
                        .HasDefaultValueSql("0");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("member_id");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.Property<bool>("TalkedAboutGod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("talked_about_god")
                        .HasDefaultValueSql("0");

                    b.Property<bool>("TeachingSomeone")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("teaching_someone")
                        .HasDefaultValueSql("0");

                    b.Property<bool>("WasPresent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("was_present")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id")
                        .HasName("PK_responses");

                    b.HasIndex("ChurchId");

                    b.HasIndex("ClassId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("MemberId");

                    b.ToTable("responses", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.UserAccessClasses.Entities.UserAccessClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("class_id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<bool>("HasAccess")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("has_access")
                        .HasDefaultValueSql("0");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("PK_user_access_classes");

                    b.HasIndex("ClassId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("user_access_classes", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Users.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("id")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("AskNewPassword")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("ask_new_password")
                        .HasDefaultValueSql("0");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("company_id");

                    b.Property<DateTimeOffset>("CreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("creation_date")
                        .HasDefaultValueSql("SYSDATETIMEOFFSET()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("email");

                    b.Property<bool>("HasConfirmedEmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("has_confirmed_email")
                        .HasDefaultValueSql("0");

                    b.Property<DateTimeOffset?>("LastModified")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("last_modified");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(200)")
                        .HasColumnName("password");

                    b.Property<bool>("Removed")
                        .HasColumnType("bit")
                        .HasColumnName("removed");

                    b.Property<DateTimeOffset>("TermsAcceptanceDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("terms_acceptance_date");

                    b.Property<string>("TermsAcceptanceIp")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("terms_acceptance_ip");

                    b.HasKey("Id")
                        .HasName("PK_users");

                    b.HasIndex("CompanyId");

                    b.ToTable("users", "dbo");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Churches.Entities.Church", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("Churches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_churches_company_id");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Classes.Entities.Class", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Churches.Entities.Church", "Church")
                        .WithMany("Classes")
                        .HasForeignKey("ChurchId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_classes_church_id");

                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("Classes")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_classes_company_id");

                    b.Navigation("Church");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Members.Entities.Member", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("Members")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_members_company_id");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Quarters.Entities.Quarter", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("Quarters")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_quarters_company_id");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Responses.Entities.Response", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Churches.Entities.Church", "Church")
                        .WithMany("Responses")
                        .HasForeignKey("ChurchId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_responses_church_id");

                    b.HasOne("SabbathLoop.Domain.Commands.Classes.Entities.Class", "Class")
                        .WithMany("Responses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_responses_class_id");

                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("Responses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_responses_company_id");

                    b.HasOne("SabbathLoop.Domain.Commands.Members.Entities.Member", "Member")
                        .WithMany("Responses")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_responses_member_id");

                    b.Navigation("Church");

                    b.Navigation("Class");

                    b.Navigation("Company");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.UserAccessClasses.Entities.UserAccessClass", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Classes.Entities.Class", "Class")
                        .WithMany("UserAccessClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_user_access_classes_class_id");

                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("UserAccessClasses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_user_access_classes_company_id");

                    b.HasOne("SabbathLoop.Domain.Commands.Users.Entities.User", "User")
                        .WithMany("UserAccessClasses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_user_access_classes_user_id");

                    b.Navigation("Class");

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Users.Entities.User", b =>
                {
                    b.HasOne("SabbathLoop.Domain.Commands.Companies.Entities.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_users_company_id");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Churches.Entities.Church", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Responses");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Classes.Entities.Class", b =>
                {
                    b.Navigation("Responses");

                    b.Navigation("UserAccessClasses");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Companies.Entities.Company", b =>
                {
                    b.Navigation("Churches");

                    b.Navigation("Classes");

                    b.Navigation("Members");

                    b.Navigation("Quarters");

                    b.Navigation("Responses");

                    b.Navigation("UserAccessClasses");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Members.Entities.Member", b =>
                {
                    b.Navigation("Responses");
                });

            modelBuilder.Entity("SabbathLoop.Domain.Commands.Users.Entities.User", b =>
                {
                    b.Navigation("UserAccessClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
