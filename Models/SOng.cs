using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApplication.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        public int ArtistId { get; set; }

        public int BandId { get; set; }

        public int CategoryId { get; set; }

        public String ArtistName { get; set; }

        public String timeDuration { get; set; }

        public int Popularity { get; set; }

        [Column(TypeName="decimal(18, 2)")]
        public double Price { get; set; }

    }
}
