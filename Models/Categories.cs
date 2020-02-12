using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApplication.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        public String CategoryName { get; set; }

        public IList<Bands> bandList { get; set; } 
    }
}
