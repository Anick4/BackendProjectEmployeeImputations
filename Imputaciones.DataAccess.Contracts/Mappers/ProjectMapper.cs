using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
