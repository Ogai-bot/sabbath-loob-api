using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SabbathLoop.Domain.Commands.Companies.Entities.DbConfig
{
	public class CompanyDbConfig: IEntityTypeConfiguration<Company>
	{
        void IEntityTypeConfiguration<Company>.Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("companies", "dbo");
			builder.HasKey(b => b.Id).HasName("PK_companies");
            builder.Property(b => b.Id).HasColumnName("id").HasColumnType("uniqueidentifier").HasDefaultValueSql("NEWID()").IsRequired();
            builder.Property(b => b.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
            builder.Property(b => b.CreationDate).HasColumnName("creation_date").HasColumnType("datetimeoffset").HasDefaultValueSql("SYSDATETIME()").IsRequired();
            builder.Property(b => b.LastModified).HasColumnName("last_modified").HasColumnType("datetimeoffset");
            builder.Property(b => b.Removed).HasColumnName("removed").HasColumnType("bit").IsRequired();
            builder.HasQueryFilter(b => !b.Removed);
        }
    }
}

