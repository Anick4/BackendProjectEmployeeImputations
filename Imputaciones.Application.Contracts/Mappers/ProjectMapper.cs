using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class ProjectMapper
    {
       // Entity Project -> ProjectModel
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


        // ProjectDto -> ProjectModel
        public static ProjectModel ToProjectModel(this ProjectDto project)
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


        // ProjectDto -> ProjectModelReviewer
        public static ProjectModelReviewer ToProjectModelReviewer(this ProjectDto projectDto)
        {
            return new ProjectModelReviewer()
            {
                ProjectName = projectDto.Name,
                Project_Id = projectDto.Project_Id
            };
        }


        // ProjectModel -> ProjectResponse
        public static ProjectResponse ToProjectResponseMapper(this ProjectModel projectModel)
        {
            return new ProjectResponse()
            {
                Project_Id = projectModel.Project_Id,
                Name = projectModel.Name,
                State = projectModel.State,
                Generic = projectModel.Generic,
                Responsible_Id = projectModel.Responsible_Id
            };

        }


        // List<Project> -> List<ProjectModel>
        public static List<ProjectModel> ToListProjectModel(this List<Project> projects)
        {
            List<ProjectModel> projectModelList = new ();
            foreach (var item in projects)
            {
                projectModelList.Add(item.ToProjectModel());
            }
            return projectModelList;
        }


        // List<ProjectDto> -> List<ProjectModelReviewer>
        public static List<ProjectModelReviewer> ToListDtoProjectModel(this List<ProjectDto> projectsList)
        {
            List<ProjectModelReviewer> projectModelList = new();
            foreach (var item in projectsList)
            {
                projectModelList.Add(item.ToProjectModelReviewer());
            }
            return projectModelList;
        }


        // List<ProjectModelReviewer> -> List<ProjectResponseReviewer>
        public static List<ProjectResponseReviewer> ToProjectListResponseReviewerMapper( this List<ProjectModelReviewer> projectModelList)
        {
            List<ProjectResponseReviewer> list = new();
            foreach(var item in projectModelList)
            {
                list.Add(new ProjectResponseReviewer()
                {
                    ProjectName = item.ProjectName,
                    Project_Id = item.Project_Id
                });
            }
            return list;
        }
    }
}

