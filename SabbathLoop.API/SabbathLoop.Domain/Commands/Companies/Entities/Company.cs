using System;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Companies.Entities
{
	public class Company : EntityBase
    {
		public Guid Id { get; private set; }
		public string Name { get; private set; }
		public DateTimeOffset? LastModified { get; private set; }
		public DateTimeOffset CreationDate { get; private set; }

		public ICollection<Church> Churches { get; private set; }

		protected Company()
		{
			CreationDate = DateTimeOffset.UtcNow;
		}

        public Company(string name, Guid? id = null) : this()
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
        }
    }
}

