using MeteringApplication.Data;
using MeteringApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeteringApplication.Controllers{

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase{
        
        private readonly MockCommandsRepo _repository = new MockCommandsRepo(); 

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands(){
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Command>> GetCommandById(int id){
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }

    }
}