﻿using Imputaciones.Application.BusinessModel.Models;
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
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public Task<ProjectModel> AddProject(ProjectModel projectModel)
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
