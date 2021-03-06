using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Requests;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;
using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.Application
{
    public class ImputationService : IImputationService
    {
        private readonly IImputationRepository _imputationRepository;

        public ImputationService(IImputationRepository imputationRepository)
        {
            _imputationRepository = imputationRepository;
        }

        public async Task<bool> InsertImputation(List<ImputationInsertRequest> imputationRequest)
        {
            List<ImputationModel> modelList = imputationRequest.ToImputationModelMapper();
            try
            {
                foreach (var model in modelList)
                {
                    if(_imputationRepository.GetByID(model.Imputation_Id) == null)
                    {
                        _imputationRepository.Insert(model.ToImputationMapper());
                        _imputationRepository.SaveChanges();
                    }
                    else
                    {
                        var entity = _imputationRepository.GetByID(model.Imputation_Id);
                        entity.Hours = model.Hours;
                        entity.State = model.State;
                        _imputationRepository.SaveChanges();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<ImputationModel>> GetAllImputations()
        {
            var List = await _imputationRepository.GetAsync();
            return List.ToList().ToListImputationModel();
        }

        public async Task<List<ImputationModel>> GetImputationsById(int id)
        {
            var list = await _imputationRepository.GetAsync(x => x.Project_Id == id);
            return list.ToList().ToListImputationModel();
        }


        public async Task<List<ImputationResponseModel>> GetImputationsWithProjectByEmployeeByWeek(int id, int week )
        {
            var result = await _imputationRepository.GetImputationsWithProjectByEmployeeByWeek(id, week);
            return result.ToListModelResponseMapper(); 
        }

        public async Task<List<TotalHoursModel>> GetExtraHours(int Employeeid, int week )
        {
            var result = await _imputationRepository.GetDailyHours(Employeeid, week);
            return result.ToTotalHoursModelMapper(); 
        }

        public async Task<List<ImputationsForReviewModel>> GetImputationsByProject(int ProjecId)
        {
            var result = await _imputationRepository.GetImputationsByProject(ProjecId);
            return result.ToListModelMapper().OrderBy(x => x.EmployeeName).ToList();
        }

        public async Task<bool> ChangeImputationStatus(int id, int status)
        {
            try
            {
                var result = _imputationRepository.GetByID(id);
                result.State = (StateEnum)status;
                _imputationRepository.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> AproveAllImputations(int ProjectId)
        {
            try
            {
                var result = await GetImputationsById(ProjectId);
                foreach (var item in result)
                {
                    _imputationRepository.GetByID(item.Imputation_Id).State = (StateEnum)2;
                    _imputationRepository.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
