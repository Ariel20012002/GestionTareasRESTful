using GestionTareasRESTful.Application.Tareas.Commands.DeleteTarea;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionTareasRESTful.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EliminarTareaLogicoController : ApiControllerBase
    {
        [HttpPut("EliminarTarea/{id}")]
        public async Task<IActionResult> Update(int id, DeleteTareaCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            await Mediator.Send(command);
            return NoContent();
        }
    }
}
