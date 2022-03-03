using Imputations.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Imputations.DataAccess.Contracts
{
    public interface IApplicationDbContext
    {
        DbSet<Employee> employees { get; set; }
        DbSet<Calendar> calendars { get; set; }
        DbSet<Imputation> imputations { get; set; }
        DbSet<Project> projects { get; set; }
        DbSet<Role> roles { get; set; }

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
