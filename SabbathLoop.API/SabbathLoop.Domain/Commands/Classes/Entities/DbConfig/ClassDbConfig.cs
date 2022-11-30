using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabbathLoop.Domain.Commands.Churches.Entities;

namespace SabbathLoop.Domain.Commands.Classes.Entities.DbConfig
{
	public class ClassDbConfig : IEntityTypeConfiguration<Class>
    {
        void IEntityTypeConfiguration<Class>.Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("classes", "dbo");
            builder.HasKey(b => b.Id).HasName("PK_classes");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("company_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Company).WithMany(b => b.Classes).HasForeignKey(b => b.CompanyId).HasConstraintName("FK_classes_company_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.ChurchId).HasColumnName("church_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Church).WithMany(b => b.Classes).HasForeignKey(b => b.ChurchId).HasConstraintName("FK_classes_church_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIMEOFFSET()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

