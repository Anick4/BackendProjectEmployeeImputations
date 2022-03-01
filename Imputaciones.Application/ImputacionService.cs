using Imputaciones.Application.BusinessModel.Models;
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
        public Task<ImputacionesModel> AddImputaciones(ImputacionesModel imputacionesModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<ImputacionesModel>> GetAllImputaciones()
        {
            throw new NotImplementedException();
        }

        public ImputacionesModel GetImputacionesById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
