using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;

namespace SabbathLoop.Domain.Commands.UserAccessClasses.Entities.DbConfig
{
	public class UserAccessClassDbConfig : IEntityTypeConfiguration<UserAccessClass>
    {
        void IEntityTypeConfiguration<UserAccessClass>.Configure(EntityTypeBuilder<UserAccessClass> builder)
        {
            builder.ToTable("user_access_classes", "dbo");
            builder.HasKey(b => b.Id).HasName("PK_user_access_classes");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.UserId).HasColumnName("user_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.User).WithMany(b => b.UserAccessClasses).HasForeignKey(b => b.UserId).HasConstraintName("FK_user_access_classes_user_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.ClassId).HasColumnName("class_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Class).WithMany(b => b.UserAccessClasses).HasForeignKey(b => b.ClassId).HasConstraintName("FK_user_access_classes_class_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("company_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Company).WithMany(b => b.UserAccessClasses).HasForeignKey(b => b.CompanyId).HasConstraintName("FK_user_access_classes_company_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.HasAccess).HasColumnName("has_access").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIMEOFFSET()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

