using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareaById
{
    public class GetTareaByIdQuery : IRequest<TareaVm>
    {
        public int TareaId { get; set; }
    }
}
