using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class UserRole:ModelBase 
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ConfigRoleId { get; set; }
        public ConfigRole ConfigRole { get; set; }
    }
}
