using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class RoleEntitlement:ModelBase
    {
        public int Id { get; set; }
        public int ConfigRoleId { get; set; }
        public ConfigRole ConfigRole { get; set; }
        public int ConfigEntitlementId { get; set; }
        public ConfigEntitlement ConfigEntitlement { get; set; }
    }
}
