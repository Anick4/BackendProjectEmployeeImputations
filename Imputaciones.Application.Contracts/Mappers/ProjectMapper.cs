using Imputations.Application.BusinessModel.Models;
using Imputations.Application.BusinessModel.Responses;
using Imputations.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.Contracts.Mappers
{
    public static class ProjectMapper
    {
        public static ProjectModel toProjectModel(this Project project)
        {
            return new ProjectModel()
            {
                Project_Id = project.Project_Id,
                Name = project.Name,
                State = project.State,
                Generic = project.Generic,
                Responsible_Id = project.Responsible_Id,
            };
        }

        public static ProjectResponse toProjectResponseMapper(this ProjectModel projectModel)
        {
            return new ProjectResponse()
            {
                Project_Id = projectModel.Project_Id,
                Name = projectModel.Name,
                State = projectModel.State,
                Generic = projectModel.Generic,
                Responsible_Id = projectModel.Responsible_Id,
            };

        }



    }
}

