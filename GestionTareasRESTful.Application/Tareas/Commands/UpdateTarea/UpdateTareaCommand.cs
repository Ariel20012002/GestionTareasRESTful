using MediatR;
using System.ComponentModel.DataAnnotations;

namespace GestionTareasRESTful.Application.Tareas.Commands.UpdateTarea
{
    public class UpdateTareaCommand : IRequest<int>
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(255)]
        public string? Comentario { get; set; }
        public int Est_Tarea { get; set; }
    }
}
