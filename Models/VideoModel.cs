using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace videos_steam.Models
{
    public class VideoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
    }
}