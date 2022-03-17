using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Requests;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IImputationService
    {
        Task<List<ImputationModel>> GetAllImputations();
        Task<List<ImputationModel>> GetImputationsById(int id);
        Task<bool> InsertImputation(List<ImputationInsertRequest> imputationRequest);
        Task<List<ImputationResponseModel>> GetImputationsWithProjectByEmployeeByWeek(int id, int week);
        public Task<List<ImputationsForReviewModel>> GetImputationsByProject(int ProjecId);
        public Task<bool> ChangeImputationStatus(int id, int status);
        public Task<bool> AproveAllImputations(int ProjectId);
    }
}
