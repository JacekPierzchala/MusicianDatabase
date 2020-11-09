using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public abstract class BaseEntity:ModelBase
    {
        public bool Deleted { get; set; }

        public int? DeletedById { get; set; }
        public User DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }
        public int AddedById { get; set; }
        public User AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public bool Locked { get; set; }
        public int? LockedById { get; set; }
        public User LockedBy { get; set; }

        public int? LastEditedById { get; set; }
        public User LastEditedBy { get; set; }

        public DateTime? LastEditedDate { get; set; }
    }
}
