using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class RolMapper
    {
        public static RolModel toRolModelMapper(this RolDto rolDto)
        {
            return new RolModel()
            {
                IdRol = rolDto.IdRol,
                Name = rolDto.Name,
            };
        }

        public static RolResponse toRolResponseMapper(this RolModel rolModel)
        {
            return new RolResponse()
            {
                IdRol = rolModel.IdRol,
                Name = rolModel.Name
            };
        }
    }
}
