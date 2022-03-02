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
    public static class RolMapper
    {
        public static RolDto ToRolDtoMapper(this Rol rol)
        {
            return new RolDto()
            {
                IdRol = rol.IdRol,
                Name = rol.Name,
            };
        }
    }
}
