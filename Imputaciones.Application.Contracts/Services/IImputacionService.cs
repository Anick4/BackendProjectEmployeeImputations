using Imputaciones.Application.BusinessModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IImputacionService
    {
        Task<List<ImputacionesModel>> GetAllImputaciones();
        ImputacionesModel GetImputacionesById(int id);
        Task<ImputacionesModel> AddImputaciones(ImputacionesModel imputacionesModel);
    }
}
