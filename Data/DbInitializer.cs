using MusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApplication.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MusicStoreDbContext context)
        {
            context.Database.EnsureCreated();
            
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            using (context)
            {
                //Add songs
                var songs = new Song[]
                    {
                    new Song { ArtistId = 1, BandId = 1, CategoryId = 1, ArtistName = "Nick Carter", Popularity = 5, Price = 1.29, timeDuration = "3.39"},
                    new Song { ArtistId = 2, BandId = 1, CategoryId = 1, ArtistName = "Kevin Richardson", Popularity = 3, Price = 3.29, timeDuration = "3.39"},
                    new Song { ArtistId = 3, BandId = 1, CategoryId = 1, ArtistName = "Nick Carter", Popularity = 2, Price = 2.29, timeDuration = "3.39"}
                    };
                foreach (Song s in songs)
                {
                    context.Songs.Add(s);
                }
                context.SaveChanges();

                //Add artists
                var artists = new Artist[]
                    {
                    new Artist { ArtistName = "Nick Carter", BandId = 1 },
                    new Artist { ArtistName = "Kevin Richardson", BandId = 1 },
                    new Artist { ArtistName = "Adele", BandId = 3 }
                    };
                foreach (Artist a in artists)
                {
                    context.Artists.Add(a);
                }
                context.SaveChanges();

                //Add bands
                var bandArray = new Bands[] {
                new Bands { BandName = "BackStreet Boys", CategoryId = 1},
                new Bands { BandName = "Blue", CategoryId = 1},
                new Bands { BandName = "Adele", CategoryId = 1}
            };

                foreach (Bands b in bandArray)
                {
                    context.Bands.Add(b);
                }
                context.SaveChanges();


                List<Bands> list = new List<Bands>(bandArray);
                //Add Categories
                var categories = new Categories[] {
                new Categories { CategoryName = "Pop", bandList = list}
            };

                foreach (Categories c in categories)
                {
                    context.Categories.Add(c);
                }
                context.SaveChanges();
            }
        }
    }
}
