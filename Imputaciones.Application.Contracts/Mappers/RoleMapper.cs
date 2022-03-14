using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class RoleMapper
    {
        public static RoleModel ToRoleModelMapper(this RoleDto roleDto)
        {
            return new RoleModel()
            {
                Role_Id = roleDto.Role_Id,
                Role_Name = roleDto.Role_Name,
     
            };
        }

        public static RoleResponse ToRoleResponseMapper(this RoleModel roleModel)
        {
            return new RoleResponse()
            {
                Role_Id = roleModel.Role_Id,
                Role_Name = roleModel.Role_Name
            };
        }

        public static RoleModel ToRoleModelMapper(this Role role)
        {
            return new RoleModel()
            {
                Role_Id = role.Role_Id,
                Role_Name = role.Role_Name,

            };
        }


    }
}
