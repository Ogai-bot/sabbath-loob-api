using System;
using SabbathLoop.Domain.Commands.Classes.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Responses.Entities;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Churches.Entities
{
	public class Church: EntityBase
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
        public DateTimeOffset CreationDate { get; private set; }

        public ICollection<Class> Classes { get; private set; }
        public ICollection<Response> Responses { get; private set; }

        protected Church()
		{
            CreationDate = DateTimeOffset.UtcNow;
        }

        public Church(string name, Guid companyId, Guid? id = null): this()
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            CompanyId = companyId;
        }
    }
}

