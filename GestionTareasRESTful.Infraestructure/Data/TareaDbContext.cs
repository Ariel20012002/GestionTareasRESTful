using GestionTareasRESTful.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace GestionTareasRESTful.Infraestructure.Data
{
    public class TareaDbContext : DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Tarea> Tareas { get; set; }
    }
}
