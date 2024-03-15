using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using videos_steam.Dtos;
using videos_steam.Models;

namespace videos_steam.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VideoDto, VideoModel>();
        }
    }
}