using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Commands.UpdateTarea
{
    public class UpdateTareaCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Comentario { get; set; }
        public int Est_Tarea { get; set; }
        public int Estado { get; set; }
        public DateTime Update_Time { get; set; } = DateTime.Now;
    }
}
