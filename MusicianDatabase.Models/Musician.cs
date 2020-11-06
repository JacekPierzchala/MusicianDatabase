using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicianDatabase.Models
{
    public class Musician:ModelBase
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
        public bool Deleted { get; set; }
        
        public int? DeletedById { get; set; }
        public User DeletedBy { get; set; }

        public int  AddedById { get; set; }
        public User AddedBy { get; set; }

        public bool Locked { get; set; }
        public int? LockedById { get; set; }
        public User LockedBy { get; set; }

        public int? LastEditedById { get; set; }
        public User LastEditedBy { get; set; }


        
    }
}
