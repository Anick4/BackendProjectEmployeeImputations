using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class ProjectMapper
    {

        //  Dto -> Entity
        public static Project ToProjectMapper(this ProjectDto projectDto)
        {
            return new Project()
            {
                Project_Id = projectDto.Project_Id,
                State = projectDto.State,
                Generic = projectDto.Generic,
                Name = projectDto.Name,
                Responsible_Id = projectDto.Responsible_Id
            };
        }

        //  Entity -> Dto
        public static ProjectDto ToProjectDtoMapper(this Project project)
        {
            return new ProjectDto()
            {
                Project_Id = project.Project_Id,
                State = project.State,
                Generic = project.Generic,
                Name = project.Name,
                Responsible_Id = project.Responsible_Id
            };
        }

        public static List<ProjectDto> ToProjectListDtoMapper(this List<Project> projectList)
        {
            List<ProjectDto> list = new();
            foreach (var item in projectList)
            {
                list.Add(new ProjectDto()
                {
                    Project_Id = item.Project_Id,
                    State = item.State,
                    Generic = item.Generic,
                    Name = item.Name,
                    Responsible_Id = item.Responsible_Id
                });
            }
            return list;
        }
    }
}

