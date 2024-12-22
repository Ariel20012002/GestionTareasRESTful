using GestionTareasRESTful.Domain.Entity;
using GestionTareasRESTful.Domain.Repository;
using GestionTareasRESTful.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GestionTareasRESTful.Infraestructure.Repository
{
    public class TareaRepository : ITareaRepository
    {
        private readonly TareaDbContext _tareaDbContext;

        public TareaRepository(TareaDbContext tareaDbContext) { 
            _tareaDbContext = tareaDbContext;
        }

        public async Task<Tarea> CreateAsync(Tarea tarea)
        {
            await _tareaDbContext.Tareas.AddAsync(tarea);
            await _tareaDbContext.SaveChangesAsync();
            return tarea;
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _tareaDbContext.Tareas
                   .Where(model => model.Id == id)
                   .ExecuteDeleteAsync();
        }

        public async Task<List<Tarea>> GetAllTareasAsync()
        {
            return await _tareaDbContext.Tareas.ToListAsync();
        }

        public async Task<Tarea> GetByIdAsync(int id)
        {
            return await _tareaDbContext.Tareas.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<int> UpdateAsync(int id, Tarea tarea)
        {
            return await _tareaDbContext.Tareas
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Id, tarea.Id)
                    .SetProperty(m => m.Nombre, tarea.Nombre)
                    .SetProperty(m => m.Comentario, tarea.Comentario)
                    .SetProperty(m => m.Est_Tarea, tarea.Est_Tarea)
                );
        }

        public async Task<int> UpdateStateAsync(int id, Tarea tarea)
        {
            return await _tareaDbContext.Tareas
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.Id, tarea.Id)
                    .SetProperty(m => m.Estado, tarea.Estado)
                );
        }
    }
}
