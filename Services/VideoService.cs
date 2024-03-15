using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using videos_steam.Dtos;
using videos_steam.Exceptions;
using videos_steam.Models;
using videos_steam.Repositories.Interfaces;
using videos_steam.Services.Interfaces;

namespace videos_steam.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _repository;
        private readonly IMapper _mapper;

        public VideoService(IVideoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<VideoModel> GetAll()
        {
            return _repository.GetAll();
        }

        public VideoModel GetById(int id)
        {
            VideoModel videoById = _repository.GetById(id) ?? throw new VSException(404, "Vídeo não encontrado");
            
            return videoById;
        }

        public VideoModel Create(VideoDto videoDto)
        {
            VideoModel videoModel = _mapper.Map<VideoModel>(videoDto);

            return _repository.Create(videoModel);
        }

        public VideoModel Update(int id, VideoDto videoDto)
        {
            VideoModel videoById = GetById(id);

            _mapper.Map(videoDto, videoById);

            return _repository.Update(videoById);
        }

        public void Delete(int id)
        {
            VideoModel videoById = GetById(id);

            _repository.Delete(videoById);
        }
    }
}