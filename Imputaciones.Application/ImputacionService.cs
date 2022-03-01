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
    public class ImputacionService : IImputacionService
    {
        private readonly IImputacionRepository _imputacionRepository;

        public ImputacionService(IImputacionRepository imputacionRepository)
        {
            _imputacionRepository = imputacionRepository;
        }
        public Task<ImputacionModel> AddImputaciones(ImputacionModel imputacionesModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ImputacionModel>> GetAllImputaciones()
        {
            var List = await _imputacionRepository.GetAsync();
            return List.ToList().toListImputacionModel();
        }

        public ImputacionModel GetImputacionesById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
