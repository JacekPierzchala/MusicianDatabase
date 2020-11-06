using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicianDatabase.Models
{
    public class User: ModelBase
    {
        public int Id { get; set; }
       
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
        
        public bool Deleted { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName="varchar(100)")]
        public string Email { get; set; }

        public List<UserRole> UserRoles { get; set; }

    }
}
