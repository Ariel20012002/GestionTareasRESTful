using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace GestionTareasRESTful.Application.Tareas.Commands.CreateTarea
{
    public class CreateTareaCommand : IRequest<TareaVm>
    {
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string? Comentario { get; set; }
        public int Est_Tarea { get; set; }
        public int Estado { get; set; }
    }
}
