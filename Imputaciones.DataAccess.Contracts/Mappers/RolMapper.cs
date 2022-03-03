using Imputations.Application.BusinessModel.Models;
using Imputations.DataAccess.Contracts.Dtos;
using Imputations.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Mappers
{
    public static class RolMapper
    {
        public static RoleDto ToRolDtoMapper(this Rol rol)
        {
            return new RoleDto()
            {
                IdRol = rol.IdRol,
                Name = rol.Name,
            };
        }
    }
}
