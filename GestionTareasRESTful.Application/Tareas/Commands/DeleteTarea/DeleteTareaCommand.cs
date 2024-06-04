using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Commands.DeleteTarea
{
    public class DeleteTareaCommand : IRequest<int>
    {
        public int Id { get; set; }
        public int Estado { get; set; }
    }
}
