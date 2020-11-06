using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicianDatabase.Models
{
    public class ConfigRole:ModelBase
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        [Column(TypeName ="varchar(100)")]
        public string Role { get; set; }

        public List<RoleEntitlement> RoleEntitlements { get; set; }

    }
}
