using Imputations.Application.BusinessModel.Models;
using Imputations.Application.BusinessModel.Responses;
using Imputations.DataAccess.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.Contracts.Mappers
{
    public static class RoleMapper
    {
        public static RoleModel toRoleModelMapper(this RoleDto roleDto)
        {
            return new RoleModel()
            {
                Role_Id = roleDto.Role_Id,
                Name = roleDto.Name,
            };
        }

        public static RoleResponse toRoleResponseMapper(this RoleModel roleModel)
        {
            return new RoleResponse()
            {
                Role_Id = roleModel.Role_Id,
                Name = roleModel.Name
            };
        }
    }
}
