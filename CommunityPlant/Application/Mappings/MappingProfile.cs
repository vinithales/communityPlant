using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace CommunityPlant.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile(){
            CreateMap<Task, TaskResponseDTO>().ReverseMap();
            CreateMap<Garden, GardenResponseDTO>().ReverseMap();
            CreateMap<User, UserResponseDTO>().ReverseMap();
            CreateMap<TaskHistory, TaskHistoryResponseDTO>().ReverseMap();
            CreateMap<WeatherData, WeatherDataResponseDTO>().ReverseMap();
        }
        
    }
}