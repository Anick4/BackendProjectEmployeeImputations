using Imputations.Application.BusinessModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.Contracts.Services
{
    public interface IProjectService
    {
        Task<List<ProjectModel>> GetAllProjects();
        ProjectModel GetProjectById(int id);
        Task<ProjectModel> AddProject(ProjectModel projectModel);
    }
}
