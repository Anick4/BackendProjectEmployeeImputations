using Imputations.Application.BusinessModel.Models;
using Imputations.Application.Contracts.Mappers;
using Imputations.Application.Contracts.Services;
using Imputations.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application
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
    }
}
