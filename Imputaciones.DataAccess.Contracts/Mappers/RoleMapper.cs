using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class RoleMapper
    {
        public static RoleDto ToRolDtoMapper(this Role role)
        {
            return new RoleDto()
            {
                Role_Id = role.Role_Id,
                Role_Name = role.Role_Name,
            };
        }
    }
}
