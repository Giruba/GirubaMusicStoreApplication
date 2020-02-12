using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApplication.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        public int BandId { get; set; }

        public String ArtistName { get; set; }
    }
}
