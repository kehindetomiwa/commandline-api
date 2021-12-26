using System.Collections.Generic;
using commandline_api.Models;
using Microsoft.AspNetCore.Mvc;
using commandline_api.Data;
using AutoMapper;
using commandline_api.Dtos;

namespace commandline_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;
        private IMapper _mapper;

        public CommandsController(ICommanderRepo repository,
                                IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/command
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllCommand()
        {
            var commandItems = _repository.GetAllCommander();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));

        }

        //GET api/command/{id}
        [HttpGet("{id}")]
        public ActionResult <CommandReadDto> GetCommandByID(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            if(commandItem != null){
                return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();

        }
    }
}