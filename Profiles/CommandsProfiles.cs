using AutoMapper;
using commandline_api.Dtos;
using commandline_api.Models;

namespace commandline_api.Profiles
{
    public class CommandsProfiles : Profile{
        public CommandsProfiles()
        {
            CreateMap<Command, CommandReadDto>();
            
        }
    }
}