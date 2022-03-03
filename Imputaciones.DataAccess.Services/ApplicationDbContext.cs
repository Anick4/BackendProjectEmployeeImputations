using Imputations.DataAccess.Contracts;
using Imputations.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Services
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Employee> employees { get; set; }
        public DbSet<Calendar> calendars { get; set; }
        public DbSet<Imputation> imputations { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Role> roles { get; set; }



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