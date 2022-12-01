using System;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.UserAccessClasses.Entities;
using SabbathLoop.Domain.Commands.Users.Entities.Enums;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Users.Entities
{
	public class User: EntityBase
	{
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Gender Gender { get; private set; }
        public string Password { get; private set; }
        public bool AskNewPassword { get; private set; }
        public bool HasConfirmedEmail { get; private set; }
        public DateTimeOffset TermsAcceptanceDate { get; private set; }
        public string TermsAcceptanceIp { get; private set; }
        public Guid CompanyId { get; private set; }
        public Company Company { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
        public DateTimeOffset CreationDate { get; private set; }

        public ICollection<UserAccessClass> UserAccessClasses { get; private set; }

        public User()
		{
            CreationDate = DateTimeOffset.UtcNow;
		}

        public User(
            string name,
            string email,
            string password,
            bool askNewPassword,
            bool hasConfirmedEmail,
            DateTimeOffset termsAcceptanceDate,
            string termsAcceptanceIp,
            Guid companyId,
            Guid? id = null) : this()
        {
            Id = id ?? Guid.NewGuid();
            Name = name;
            Email = email;
            Password = password;
            AskNewPassword = askNewPassword;
            HasConfirmedEmail = hasConfirmedEmail;
            TermsAcceptanceDate = termsAcceptanceDate;
            TermsAcceptanceIp = termsAcceptanceIp;
            CompanyId = companyId;
        }
    }
}

