using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;
using SabbathLoop.Domain.Commands.Responses.Entities;

namespace SabbathLoop.Domain.Commands.Responses.Entities.DbConfig
{
	public class ResponseDbConfig : IEntityTypeConfiguration<Response>
    {
        void IEntityTypeConfiguration<Response>.Configure(EntityTypeBuilder<Response> builder)
        {
            builder.ToTable("responses", "dbo");
            builder.HasKey(b => b.Id).HasName("PK_responses");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.MemberId).HasColumnName("member_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Member).WithMany(b => b.Responses).HasForeignKey(b => b.MemberId).HasConstraintName("FK_responses_member_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.ClassId).HasColumnName("class_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Class).WithMany(b => b.Responses).HasForeignKey(b => b.ClassId).HasConstraintName("FK_responses_class_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.ChurchId).HasColumnName("church_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Church).WithMany(b => b.Responses).HasForeignKey(b => b.ChurchId).HasConstraintName("FK_responses_church_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("company_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Company).WithMany(b => b.Responses).HasForeignKey(b => b.CompanyId).HasConstraintName("FK_responses_company_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.WasPresent).HasColumnName("was_present").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.DailyCommunion).HasColumnName("daily_communion").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.HelpedSomeone).HasColumnName("helped_someone").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.TalkedAboutGod).HasColumnName("talked_about_god").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.TeachingSomeone).HasColumnName("teaching_someone").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.BaptizedSomeoneThisYear).HasColumnName("baptized_someone_this_year").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.DiscipleSomeone).HasColumnName("disciple_someone").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIMEOFFSET()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

