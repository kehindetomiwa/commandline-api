using AutoMapper;
using commandline_api.Dtos;
using commandline_api.Models;

namespace commandline_api.Profiles
{
    public class CommandsProfiles : Profile{
        public CommandsProfiles()
        {
            //Source - Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            
        }
    }
}