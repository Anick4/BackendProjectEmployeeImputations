using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class ProjectMapper
    {
        public static ProjectModel ToProjectModel(this Project project)
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

        public static ProjectResponse ToProjectResponseMapper(this ProjectModel projectModel)
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

        public static List<ProjectModel> ToListProjectModel(this List<Project> projects)
        {
            List<ProjectModel> projectModelList = new ();
            foreach (var item in projects)
            {
                projectModelList.Add(item.ToProjectModel());
            }
            return projectModelList;
        }



    }
}

