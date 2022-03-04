using Imputaciones.Application.BusinessModel.Models;
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
        public Task<ImputationModel> AddImputations(ImputationModel imputationsModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ImputationModel>> GetAllImputations()
        {
            var List = await _imputationRepository.GetAsync();
            return List.ToList().toListImputationModel();
        }

        public ImputationModel GetImputationsById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<ImputationModel>> GetImputationsByEmployeeByWeek(int id, int week )
        {
            var result = await _imputationRepository.GetImputationsByEmployeeByWeek(id, week);

            return result.ToImputationModelMapper();
            
            
        }
    }
}
