using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Repository;

namespace Imputaciones.DataAccess.Contracts.Repositories
{
    public interface IImputationRepository : IGenericRespository<Entities.Imputation>
    {
        public Task<List<ImputationResponseDto>> GetImputationsWithProjectByEmployeeByWeek(int id, int week);
        public Task<int?> CheckCalendar(int id);
        public Task<List<TotalHoursDto>> GetDailyHours(int Employeeid, int week);
        public Task<List<ImputationsForReviewDto>> GetImputationsByProject(int ProjectId);
    }
}
