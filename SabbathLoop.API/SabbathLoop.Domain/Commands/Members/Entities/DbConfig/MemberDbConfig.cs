using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;

namespace SabbathLoop.Domain.Commands.Members.Entities.DbConfig
{
	public class MemberDbConfig : IEntityTypeConfiguration<Member>
    {
        void IEntityTypeConfiguration<Member>.Configure(EntityTypeBuilder<Member> builder)
        {
            builder.ToTable("members", "dbo");
            builder.HasKey(b => b.Id).HasName("PK_members");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.Name).HasColumnName("name").HasColumnType("varchar(200)").IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("company_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Company).WithMany(b => b.Members).HasForeignKey(b => b.CompanyId).HasConstraintName("FK_members_company_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.Email).HasColumnName("email").HasColumnType("varchar(200)").IsRequired();
            builder.Property(b => b.Password).HasColumnName("password").HasColumnType("varchar(200)").IsRequired();
            builder.Property(b => b.AskNewPassword).HasColumnName("ask_new_password").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.HasConfirmedEmail).HasColumnName("has_confirmed_email").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.TermsAcceptanceDate).HasColumnName("terms_acceptance_date").HasColumnType("datetimeoffset");
            builder.Property(b => b.TermsAcceptanceIp).HasColumnName("terms_acceptance_ip").HasColumnType("varchar(20)");
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIMEOFFSET()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

