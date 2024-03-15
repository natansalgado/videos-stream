using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using videos_steam.Context;
using videos_steam.Models;
using videos_steam.Repositories.Interfaces;

namespace videos_steam.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly VSContext _context;

        public VideoRepository(VSContext context)
        {
            _context = context;
        }

        public List<VideoModel> GetAll()
        {
            return _context.Videos.ToList();
        }

        public VideoModel GetById(int id)
        {
            return _context.Videos.FirstOrDefault(x => x.Id == id);
        }

        public VideoModel Create(VideoModel videoModel)
        {
            _context.Videos.Add(videoModel);
            _context.SaveChanges();

            return videoModel;
        }

        public VideoModel Update(VideoModel videoModel)
        {
            _context.Videos.Update(videoModel);
            _context.SaveChanges();

            return videoModel;
        }

        public void Delete(VideoModel videoModel)
        {
            _context.Remove(videoModel);
            _context.SaveChanges();
        }
    }
}