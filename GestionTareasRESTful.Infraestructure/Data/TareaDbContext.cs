using GestionTareasRESTful.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
