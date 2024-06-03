using AutoMapper;
using GestionTareasRESTful.Application.Tareas.Queries.GetTareas;
using GestionTareasRESTful.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Application.Tareas.Queries.GetTareaById
{
    public class GetTareaByIdQueryHandler : IRequestHandler<GetTareaByIdQuery, TareaVm>
    {
        private readonly ITareaRepository _tareaRepository;
        private readonly IMapper _mapper;

        public GetTareaByIdQueryHandler(ITareaRepository tareaRepository, IMapper mapper) {
            _tareaRepository = tareaRepository;
            _mapper = mapper;
        }

        public async Task<TareaVm> Handle(GetTareaByIdQuery request, CancellationToken cancellationToken)
        {
           var tarea = await _tareaRepository.GetByIdAsync(request.TareaId);
           return _mapper.Map<TareaVm>(tarea);
        }
    }
}
