using System;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Quarters.Entities
{
	public class Quarter: EntityBase
	{
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; }
        public DateTimeOffset StartDate { get; private set; }
        public DateTimeOffset EndDate { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
        public DateTimeOffset CreationDate { get; private set; }

        public Quarter()
		{
            CreationDate = DateTimeOffset.UtcNow;
		}

        public Quarter(
            string name,
            Guid companyId,
            DateTimeOffset startDate,
            DateTimeOffset endDate,
            Guid? id = null) : this()
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            CompanyId = companyId;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}

