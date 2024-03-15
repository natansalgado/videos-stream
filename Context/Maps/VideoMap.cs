using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using videos_steam.Models;

namespace videos_steam.Context.Maps
{
    public class VideoMap : IEntityTypeConfiguration<VideoModel>
    {
        public void Configure(EntityTypeBuilder<VideoModel> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description);
            builder.Property(x => x.Views).HasDefaultValue(0);
            builder.Property(x => x.Likes).HasDefaultValue(0);
            builder.Property(x => x.Date).HasDefaultValue(DateTime.Now);
        }
    }
}