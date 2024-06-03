using AutoMapper;
using GestionTareasRESTful.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            /*
            var tareaList = tareas.Select(t => new TareaVm {
                    Id = t.Id,
                    Nombre = t.Nombre,
                    Comentario = t.Comentario,
                    Est_Tarea = t.Est_Tarea,
                    Estado = t.Estado,
                    Create_Time = t.Create_Time,
                    Update_Time = t.Update_Time
            }).ToList();
            */
            var tareaList = _mapper.Map<List<TareaVm>>(tareas);
            return tareaList;
        }
    }
}
