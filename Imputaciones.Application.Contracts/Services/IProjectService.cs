using Imputaciones.Application.BusinessModel.Models;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IProjectService
    { 
        public ProjectModel GetProjectById(int id);


    }
}
