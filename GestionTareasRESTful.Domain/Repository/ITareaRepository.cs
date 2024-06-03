using GestionTareasRESTful.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTareasRESTful.Domain.Repository
{
    public interface ITareaRepository
    {
        Task<List<Tarea>> GetAllTareasAsync();
        Task<Tarea> GetByIdAsync(int id);
        Task<Tarea> CreateAsync(Tarea tarea);
        Task<Tarea> UpdateAsync(int id, Tarea tarea);
        Task DeleteAsync(int id);
    }
}
