using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;

namespace Imputaciones.Application
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public ProjectModel GetProjectById(int id)
        {
            var result = _projectRepository.GetByID(id);
            return result.ToProjectModel();
        }

        public async Task<List<ProjectModel>> GetAllProjectsByEmployee(int idEmployee)  
        {
            return null;  //***************************???????????????????????????????????????????
        }

    }
}

