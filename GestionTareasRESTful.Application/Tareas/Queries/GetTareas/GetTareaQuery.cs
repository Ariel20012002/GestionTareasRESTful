using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareas
{
    public class GetTareaQuery : IRequest<List<TareaVm>>
    {
    }
    
    //public record GetTareaQuery : IRequest<List<TareaVm>>;
}
