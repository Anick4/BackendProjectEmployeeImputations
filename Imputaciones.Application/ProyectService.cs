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
    public class ProyectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProyectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public Task<ProjectModel> AddProyecto(ProjectModel projectModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjectModel>> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public ProjectModel GetProjectById(int id)
        {
            var result = _projectRepository.GetByID(id);
            return result.toProjectModel();
        }
    }
}

