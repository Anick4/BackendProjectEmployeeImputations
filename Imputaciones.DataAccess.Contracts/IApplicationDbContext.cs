using Imputaciones.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Imputaciones.DataAccess.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Empleado> empleados { get; set; }
        DbSet<Calendario> calendarios { get; set; }
        DbSet<Imputacion> imputaciones { get; set; }
        DbSet<Proyecto> proyectos { get; set; } 
        
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
