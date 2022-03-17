using Imputaciones.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Imputaciones.DataAccess.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Calendar> Calendars { get; set; }
        DbSet<Imputation> Imputations { get; set; }
        DbSet<Project> Projects { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Employees_Projects> Employees_projects { get; set; }
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
