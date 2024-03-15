using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using videos_steam.Dtos;
using videos_steam.Models;

namespace videos_steam.Repositories.Interfaces
{
    public interface IVideoRepository
    {
        List<VideoModel> GetAll();
        VideoModel GetById(int id);
        VideoModel Create(VideoModel videoModel);
        VideoModel Update(VideoModel videoModel);
        void Delete(VideoModel videoModel);
    }
}