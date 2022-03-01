using Imputaciones.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Imputaciones.DataAccess.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Empleado> Empleados { get; set; }
<<<<<<< HEAD
        DbSet<Calendario> Calendarios { get; set; }

=======
        DbSet<Imputacion> Imputaciones { get; set; }
        DbSet<Proyecto> Proyectos { get; set; } 
        
>>>>>>> AdriBranch
        int SaveChanges();
        void Dispose();

        EntityEntry<TEntity> GetEntry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<T> GetEntitySet<T>() where T : class;

        DatabaseFacade TheDatabase
        {
            get;
        }
    }
}
