using GestionTareasRESTful.Application.Tareas.Commands.CreateTarea;
using GestionTareasRESTful.Application.Tareas.Commands.DeleteTarea;
using GestionTareasRESTful.Application.Tareas.Commands.UpdateTarea;
using GestionTareasRESTful.Application.Tareas.Queries.GetTareaById;
using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using Microsoft.AspNetCore.Mvc;

namespace GestionTareasRESTful.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ApiControllerBase
    {

        //[HttpGet]
        [HttpGet("get-tareas")]
        public async Task<IActionResult> GetAll()
        {
            var tareas = await Mediator.Send(new GetTareaQuery());
            return Ok(tareas);
        }


        //[HttpGet("{id}")]
        [HttpGet("get-tareasbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tarea = await Mediator.Send(new GetTareaByIdQuery() { TareaId = id });
            if(tarea == null) {
                return NotFound();
            }
            return Ok(tarea);
        }


        //[HttpPost]
        [HttpPost("insert-tarea")]
        public async Task<IActionResult> Create(CreateTareaCommand command)
        {
            var createdTarea = await Mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new {id = createdTarea.Id}, createdTarea);
        }

        [HttpPut("actualizar-tarea/{id}")]
        public async Task<IActionResult> Update(int id, UpdateTareaCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }
            
            await Mediator.Send(command);
            return NoContent();
        }

        [HttpPut("eliminar-tarea/{id}")]
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
