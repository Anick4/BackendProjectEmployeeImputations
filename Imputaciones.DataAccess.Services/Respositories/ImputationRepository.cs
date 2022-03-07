
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;
using Imputaciones.DataAccess.Contracts.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class ImputationRepository: GenericRepository<Contracts.Entities.Imputation>, IImputationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ImputationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<List<ImputationDto>> GetImputationsByEmployeeByWeek(int id, int week)
        {

            var result = _dbContext.imputations.Where(x => x.Employee_Id == id && x.Week == week).ToList().ToImputationDtoMapper();

            return result;
            
        }
    }
}
