using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabbathLoop.Domain.Commands.Churches.Entities;

namespace SabbathLoop.Domain.Commands.Companies.Entities.DbConfig
{
	public class ChurchDbConfig : IEntityTypeConfiguration<Church>
	{
        void IEntityTypeConfiguration<Church>.Configure(EntityTypeBuilder<Church> builder)
        {
            builder.ToTable("churches", "dbo");
			builder.HasKey(b => b.Id).HasName("PK_churches");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("company_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Company).WithMany(b => b.Churches).HasForeignKey(b => b.CompanyId).HasConstraintName("FK_churches_company_id").IsRequired();
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIME()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

