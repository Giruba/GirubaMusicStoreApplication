using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApplication.Models
{
    public class Bands
    {
        [Key]
        public int BandId { get; set; }

        public int CategoryId { get; set; }

        public String BandName { get; set; }

        public IList<Artist> artists { get; set; }
        
        public IList<Song> songs { get; set; }
    }

}
