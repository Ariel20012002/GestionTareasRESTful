

using GestionTareasRESTful.Domain.Repository;
using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Commands.RemoveTarea
{
    public class RemoveTareaCommandHandler : IRequestHandler<RemoveTareaCommand, int>
    {
        private readonly ITareaRepository _tareaRepository;

        public RemoveTareaCommandHandler(ITareaRepository tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }
        public async Task<int> Handle(RemoveTareaCommand request, CancellationToken cancellationToken)
        {
            return await _tareaRepository.DeleteAsync(request.Id);
        }
    }
}
