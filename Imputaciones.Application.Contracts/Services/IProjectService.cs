using Imputaciones.Application.BusinessModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IProjectService
    { 
        ProjectModel GetProjectById(int id);
       

        public Task<List<ProjectModel>> GetAllProjectsByEmployee(int idEmployee);

    }
}
