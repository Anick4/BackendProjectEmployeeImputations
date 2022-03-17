using Imputaciones.DataAccess.Contracts;
using Imputaciones.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace Imputaciones.DataAccess.Services
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Imputation> Imputations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employees_Projects> Employees_projects { get; set; }


        #region Arquitectura generica   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IConfiguration _configuration) : base(options)
        {
          
        }

        public ApplicationDbContext(IConfiguration _configuration)
        {
            
        }

        public EntityEntry<TEntity> GetEntry<TEntity>(TEntity entity) where TEntity : class
        {
            return Entry(entity);
        }

        public DatabaseFacade TheDatabase
        {
            get
            {
                return Database;
            }
        }

        public DbSet<T> GetEntitySet<T>() where T : class
        {
            return Set<T>();
        }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Employee>().ToTable("employees");
            builder.Entity<Calendar>().ToTable("calendars");
            builder.Entity<Imputation>().ToTable("imputations");
            builder.Entity<Project>().ToTable("projects");
            builder.Entity<Role>().ToTable("roles");
            builder.Entity<Employees_Projects>().ToTable("employees_projects");

            base.OnModelCreating(builder);

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string mySqlConnectionStr = _configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)).EnableSensitiveDataLogging().UseLazyLoadingProxies();

            }

        }
    }
}