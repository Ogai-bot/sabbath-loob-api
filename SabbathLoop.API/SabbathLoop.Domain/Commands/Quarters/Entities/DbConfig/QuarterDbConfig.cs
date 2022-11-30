using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;

namespace SabbathLoop.Domain.Commands.Quarters.Entities.DbConfig
{
	public class QuarterDbConfig : IEntityTypeConfiguration<Quarter>
    {
        void IEntityTypeConfiguration<Quarter>.Configure(EntityTypeBuilder<Quarter> builder)
        {
            builder.ToTable("quarters", "dbo");
            builder.HasKey(b => b.Id).HasName("PK_quarters");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.CompanyId).HasColumnName("company_id").HasColumnType("uniqueidentifier").IsRequired();
            builder.HasOne(b => b.Company).WithMany(b => b.Quarters).HasForeignKey(b => b.CompanyId).HasConstraintName("FK_quarters_company_id").OnDelete(DeleteBehavior.NoAction).IsRequired();
            builder.Property(b => b.StartDate).HasColumnName("start_date").HasColumnType("datetimeoffset").IsRequired();
            builder.Property(b => b.EndDate).HasColumnName("end_date").HasColumnType("datetimeoffset").IsRequired();
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIMEOFFSET()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").HasDefaultValueSql("0").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

