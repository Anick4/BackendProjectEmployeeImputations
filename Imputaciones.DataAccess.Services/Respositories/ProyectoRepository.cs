using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class ProyectoRepository : GenericRepository<Proyecto>, IProyectoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProyectoRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
        }
    }
}
