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
        Task<List<ImputacionModel>> GetAllImputaciones();
        ImputacionModel GetImputacionesById(int id);
        Task<ImputacionModel> AddImputaciones(ImputacionModel imputacionesModel);
    }
}
