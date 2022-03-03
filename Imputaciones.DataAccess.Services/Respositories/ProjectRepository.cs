using Imputations.DataAccess.Contracts.Entities;
using Imputations.DataAccess.Contracts.Repositories;
using Imputations.DataAccess.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Services.Respositories
{
    public class ProyectoRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProyectoRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
        }
    }
}
