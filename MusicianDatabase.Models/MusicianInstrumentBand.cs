using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class MusicianInstrumentBand
    {
        public int Id { get; set; }
        public int BandId { get; set; }
        public Band Band { get; set; }

        public MusicianInstrument MusicianInstrument { get; set; }
        public int MusicianInstrumentId { get; set; }
    }
}
