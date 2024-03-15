using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using videos_steam.Dtos;
using videos_steam.Models;

namespace videos_steam.Services.Interfaces
{
    public interface IVideoService
    {
        List<VideoModel> GetAll();
        VideoModel GetById(int id);
        VideoModel Create(VideoDto videoDto);
        VideoModel Update(int id, VideoDto videoDto);
        void Delete(int id);
    }
}