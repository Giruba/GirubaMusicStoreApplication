using Microsoft.EntityFrameworkCore;
using MusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreApplication.Data
{
    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext(DbContextOptions<MusicStoreDbContext> options) : base(options) { 
        
        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Bands> Bands { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().ToTable("Categories");
            modelBuilder.Entity<Bands>().ToTable("Bands");
            modelBuilder.Entity<Artist>().ToTable("Artists");
            modelBuilder.Entity<Song>().ToTable("Songs")    ;
        }
    }
}
