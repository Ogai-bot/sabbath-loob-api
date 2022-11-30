using System;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Classes.Entities;
using SabbathLoop.Domain.Commands.Members.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;
using SabbathLoop.Domain.Commands.Responses.Entities;
using SabbathLoop.Domain.Commands.UserAccessClasses.Entities;
using SabbathLoop.Domain.Commands.Users.Entities;
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
		public ICollection<Class> Classes { get; private set; }
		public ICollection<Quarter> Quarters { get; private set; }
		public ICollection<User> Users { get; private set; }
		public ICollection<UserAccessClass> UserAccessClasses { get; private set; }
		public ICollection<Member> Members { get; private set; }
        public ICollection<Response> Responses { get; private set; }

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

