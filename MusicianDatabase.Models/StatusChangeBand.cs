using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class StatusChangeBand
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public Band Band { get; set; }

        public int ConfigStatusId { get; set; }
        public ConfigStatus ConfigStatus { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime TimeStamp { get; set; }

        public int Seq { get; set; }
        public string ActionLog { get; set; }

    }
}
