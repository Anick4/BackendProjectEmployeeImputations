using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Requests;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            //int employeeId = imputationRequest[0].Imputations[0].Employee_Id;
            //int calendarId = await _imputationRepository.CheckCalendar(employeeId);

            try
            {
                
                foreach (var model in modelList)
                {
                   
                    if(_imputationRepository.Equals(model.Project_Id)==false)
                    {

                        _imputationRepository.Insert(model.ToImputationMapper());
                        _imputationRepository.SaveChanges();
                    }
                    else
                    {
                        _imputationRepository.Update(model.ToImputationMapper());
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

        public ImputationModel GetImputationsById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<ImputationResponseModel>> GetImputationsWithProjectByEmployeeByWeek(int id, int week )
        {
            var result = await _imputationRepository.GetImputationsWithProjectByEmployeeByWeek(id, week);

            return result.ToListModelResponseMapper();
            
            
        }

         
    }
}
