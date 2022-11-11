using System;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Companies.Entities
{
	public class Company : EntityBase
    {
		public Guid Id { get; private set; }
		public string Name { get; private set; }
		public DateTimeOffset? LastModified { get; private set; }
		public DateTimeOffset CreationDate { get; private set; }

		protected Company()
		{
			CreationDate = DateTimeOffset.UtcNow;
		}
	}
}

