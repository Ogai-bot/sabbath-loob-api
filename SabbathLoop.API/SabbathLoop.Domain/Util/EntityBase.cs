using System;
namespace SabbathLoop.Domain.Util
{
	public abstract class EntityBase
	{
		public bool Removed { get; set; }

        public virtual void Remove() => Removed = true;
    }
}

