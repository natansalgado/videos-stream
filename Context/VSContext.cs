using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using videos_steam.Context.Maps;
using videos_steam.Models;

namespace videos_steam.Context
{
    public class VSContext : DbContext
    {
        public VSContext(DbContextOptions<VSContext> options) : base(options) { }

        public DbSet<VideoModel> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VideoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}