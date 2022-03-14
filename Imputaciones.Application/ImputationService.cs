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
        public async Task<ImputationModel> InsertImputation(ImputationInsertRequest imputationRequest)
        {
            var results = imputationRequest.Imputations;
            foreach (var result in results)
            {
             await _imputationRepository.Insert(result.ToImputationMapper());

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
