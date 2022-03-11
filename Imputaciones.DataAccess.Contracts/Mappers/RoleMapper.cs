using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class RoleMapper
    {
        public static RoleDto ToRoleDtoMapper(this Role role)
        {
            return new RoleDto()
            {
                Role_Id = role.Role_Id,
                Role_Name = role.Role_Name,
            };
        }

      
    }
}
