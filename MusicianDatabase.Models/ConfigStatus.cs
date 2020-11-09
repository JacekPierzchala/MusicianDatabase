using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class ConfigStatus:ModelBase
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public bool Deleted { get; set; }
    }
}
