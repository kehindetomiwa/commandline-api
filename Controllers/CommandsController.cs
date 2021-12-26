using System.Collections.Generic;
using commandline_api.Models;
using Microsoft.AspNetCore.Mvc;
using commandline_api.Data;



namespace commandline_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
            
        }

        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        //GET api/command
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommand()
        {
            var commandItems = _repository.GetAppCommander();
            return Ok(commandItems);

        }

        //GET api/command/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandByID(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);

        }
    }
}