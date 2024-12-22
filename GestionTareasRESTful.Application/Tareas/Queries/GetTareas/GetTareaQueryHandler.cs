using AutoMapper;
using GestionTareasRESTful.Domain.Repository;
using MediatR;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareas
{
    public class GetTareaQueryHandler : IRequestHandler<GetTareaQuery, List<TareaVm>>
    {
        private readonly ITareaRepository _tareaRepository;
        private readonly IMapper _mapper;
        public GetTareaQueryHandler(ITareaRepository tareaRepository, IMapper mapper)
        {
            _tareaRepository = tareaRepository;
            _mapper = mapper;
        }
        public async Task<List<TareaVm>> Handle(GetTareaQuery request, CancellationToken cancellationToken)
        {
            var tareas = await _tareaRepository.GetAllTareasAsync();
            var tareaList = _mapper.Map<List<TareaVm>>(tareas);
            return tareaList;
        }
    }
}
