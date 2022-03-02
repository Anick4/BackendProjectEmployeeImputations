using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class EmpleadoMapper
    {
        public static Empleado ToEmpleadoMapper(this EmpleadoDto empleadoDto)
        {
            return new Empleado()
            {
                EmpleadoId = empleadoDto.EmpleadoId,
                Nombre = empleadoDto.Nombre,
                Apellidos = empleadoDto.Apellidos,
                Calendarios_idCalendarios = empleadoDto.Calendarios_idCalendarios,
                Roles_idRoles1 = empleadoDto.Roles_idRoles1,
                Codigo_empleado = empleadoDto.Codigo_empleado,
                Contraseña = empleadoDto.Contraseña,
                Email = empleadoDto.Email,
                
            };
        }

        public static EmpleadoDto ToEmpleadoDtoMapper(this Empleado empleado)
        {
            return new EmpleadoDto
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Apellidos = empleado.Apellidos,
                Calendarios_idCalendarios = empleado.Calendarios_idCalendarios,
                Roles_idRoles1 = empleado.Roles_idRoles1,
                Codigo_empleado = empleado.Codigo_empleado,
                Contraseña = empleado.Contraseña,
                Email = empleado.Email,
                
            };
        }
    }
}
