using System;
using SabbathLoop.Domain.Commands.Churches.Entities;
using SabbathLoop.Domain.Commands.Classes.Entities;
using SabbathLoop.Domain.Commands.Companies.Entities;
using SabbathLoop.Domain.Commands.Members.Entities;
using SabbathLoop.Domain.Commands.Quarters.Entities;
using SabbathLoop.Domain.Commands.Users.Entities;
using SabbathLoop.Domain.Util;

namespace SabbathLoop.Domain.Commands.Responses.Entities
{
	public class Response : EntityBase
    {
		public Guid Id { get; private set; }
		public Guid MemberId { get; private set; }
		public Member Member { get; private set; }
		public Guid ClassId { get; private set; }
		public Class Class { get; private set; }
        public Guid ChurchId { get; private set; }
        public Church Church { get; private set; }
        public Guid CompanyId { get; private set; }
		public Company Company { get; private set; }
		public bool WasPresent { get; private set; }
		public bool DailyCommunion { get; private set; }
		public bool HelpedSomeone { get; private set; }
		public bool TalkedAboutGod { get; private set; }
		public bool TeachingSomeone { get; private set; }
		public bool BaptizedSomeoneThisYear { get; private set; }
		public bool DiscipleSomeone { get; private set; }
        public DateTimeOffset? LastModified { get; private set; }
		public DateTimeOffset CreationDate { get; private set; }

        protected Response()
		{
			CreationDate = DateTimeOffset.UtcNow;
		}

        public Response(
            Guid memberId,
            Guid classId,
            Guid churchId,
            Guid companyId,
            bool wasPresent,
            bool dailyCommunion,
            bool helpedSomeone,
            bool talkedAboutGod,
            bool teachingSomeone,
            bool baptizedSomeoneThisYear,
            bool discipleSomeone,
            Guid? id = null) : this()
        {
            Id = id ?? Guid.NewGuid();
            MemberId = memberId;
            ClassId = classId;
            ChurchId = churchId;
            CompanyId = companyId;
            WasPresent = wasPresent;
            DailyCommunion = dailyCommunion;
            HelpedSomeone = helpedSomeone;
            TalkedAboutGod = talkedAboutGod;
            TeachingSomeone = teachingSomeone;
            BaptizedSomeoneThisYear = baptizedSomeoneThisYear;
            DiscipleSomeone = discipleSomeone;
        }
    }
}

