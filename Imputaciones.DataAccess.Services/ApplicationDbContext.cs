using Imputaciones.DataAccess.Contracts;
using Imputaciones.DataAccess.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Services
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Imputacion> Imputaciones { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }



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