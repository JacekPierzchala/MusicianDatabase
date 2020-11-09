using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class Band: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DissolvedDate { get; set; }

        public int CurrentSeq { get; set; }

        public List<MusicianInstrumentBand> MusicianInstrumentBands { get; set; }

        public List<StatusChangeBand> StatusChangeBands { get; set; }
    }
}
