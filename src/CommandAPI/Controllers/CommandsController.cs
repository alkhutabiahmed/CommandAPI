using System.Collections.Generic;
using CommandAPI.Data;
using CommandAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
 {
     [Route("api/[controller]")]

     [ApiController]
public class CommandsController : ControllerBase
 {

   private readonly ICommandAPIRepo _repository;
   public CommandsController(ICommandAPIRepo repository)
   {
      this._repository = repository;
   }

     public ActionResult<IEnumerable<Command>> GetAllCommands ()
     {
        var commandItem = _repository.GetAllCommands();
        return Ok(commandItem);
     }
     [HttpGet("{id}")]
     public ActionResult<Command> GetcommandById(int Id) 
     {
    var commandItem = _repository.GetCommandById(Id);
    if(commandItem == null)
    {
        return NotFound();
    }
    return Ok(commandItem);
     }

}
}