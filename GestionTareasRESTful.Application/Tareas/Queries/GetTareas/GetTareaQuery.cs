using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareas
{
    public class GetTareaQuery : IRequest<List<TareaVm>>
    {
    }
}
