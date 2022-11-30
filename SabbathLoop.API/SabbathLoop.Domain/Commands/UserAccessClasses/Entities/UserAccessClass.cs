using System;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Classes.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;
using SabbathLoop.Domain.Commands.Users.Entities;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.UserAccessClasses.Entities
{
	public class UserAccessClass : EntityBase
    {
		public Guid Id { get; private set; }
		public Guid UserId { get; private set; }
		public User User { get; private set; }
		public Guid ClassId { get; private set; }
		public Class Class { get; private set; }
		public Guid CompanyId { get; private set; }
		public Company Company { get; private set; }
		public bool HasAccess { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
		public DateTimeOffset CreationDate { get; private set; }

        protected UserAccessClass()
		{
			CreationDate = DateTimeOffset.UtcNow;
		}

        public UserAccessClass(
            Guid userId,
            Guid classId,
            Guid companyId,
            bool hasAccess,
            Guid? id = null) : this()
        {
            Id = id ?? Guid.NewGuid();
            UserId = userId;
            ClassId = classId;
            CompanyId = companyId;
            HasAccess = hasAccess;
        }
    }
}

