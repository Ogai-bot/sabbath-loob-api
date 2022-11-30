using System;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Responses.Entities;
using SabbathLoop.Domain.Commands.UserAccessClasses.Entities;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Classes.Entities
{
	public class Class: EntityBase
	{
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; }
        public Guid ChurchId { get; private set; }
        public Church Church { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
        public DateTimeOffset CreationDate { get; private set; }

        public ICollection<UserAccessClass> UserAccessClasses { get; private set; }
        public ICollection<Response> Responses { get; private set; }

        protected Class()
		{
            CreationDate = DateTimeOffset.UtcNow;
		}

        public Class(
            string name,
            Guid companyId,
            Guid churchId,
            Guid? id = null): this()
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            CompanyId = companyId;
            ChurchId = churchId;
        }
    }
}

