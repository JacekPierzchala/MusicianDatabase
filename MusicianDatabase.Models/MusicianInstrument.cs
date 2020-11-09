using System;
using System.Collections.Generic;
using System.Text;

namespace MusicianDatabase.Models
{
    public class MusicianInstrument
    {
        public int Id { get; set; }
        public Musician Musician { get; set; }
        public int MusicianId { get; set; }
        public int ConfigInstrumentId { get; set; }
        public ConfigInstrument ConfigInstrument { get; set; }
    }
}
