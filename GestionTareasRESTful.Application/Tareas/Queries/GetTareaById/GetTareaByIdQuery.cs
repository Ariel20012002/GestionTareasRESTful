using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareaById
{
    public class GetTareaByIdQuery : IRequest<TareaVm>
    {
        public int TareaId { get; set; }
    }
}
