
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
    public class ImputacionRepository: GenericRepository<Imputation>, IImputationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ImputacionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
