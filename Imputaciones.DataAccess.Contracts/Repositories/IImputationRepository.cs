using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Repositories
{
    public interface IImputationRepository : IGenericRespository<Entities.Imputation>
    {
       //public Task<List<ImputationDto>> GetImputationsByEmployeeByWeek(int id, int week);
        public Task<List<ImputationResponseDto>> GetImputationsWithProjectByEmployeeByWeek(int id, int week);

        public Task<int> CheckCalendar(int id);
    }
}
