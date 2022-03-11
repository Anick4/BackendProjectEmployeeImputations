using Imputaciones.Application.BusinessModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IImputationService
    {
        Task<List<ImputationModel>> GetAllImputations();
        ImputationModel GetImputationsById(int id);
        Task<ImputationModel> AddImputations(ImputationModel imputationsModel);
        Task<List<ImputationResponseModel>> GetImputationsWithProjectByEmployeeByWeek(int id, int week);
    }
}
