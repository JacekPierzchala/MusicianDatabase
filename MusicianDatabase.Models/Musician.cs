using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicianDatabase.Models
{
    public class Musician:BaseEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
       

        public List<MusicianInstrument> MusicianInstruments { get; set; }


    }
}
