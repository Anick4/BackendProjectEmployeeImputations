using Imputations.DataAccess.Contracts.Dtos;
using Imputations.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Mappers
{
    public static class EmpleadoMapper
    {
        public static Employee ToEmpleadoMapper(this EmployeeDto empleadoDto)
        {
            return new Employee()
            {
                Employee_Id = empleadoDto.Employee_Id,
                Name = empleadoDto.Name,
                Surname = empleadoDto.Surname,
                Calendar_Id = empleadoDto.Calendar_Id,
                Role_Id = empleadoDto.Role_Id,
                Employee_Code = empleadoDto.Employee_Code,
                Password = empleadoDto.Password,
                Email = empleadoDto.Email,
                
            };
        }

        public static EmployeeDto ToEmpleadoDtoMapper(this Employee empleado)
        {
            return new EmployeeDto
            {
                Employee_Id = empleado.Employee_Id,
                Name = empleado.Name,
                Surname = empleado.Surname,
                Calendar_Id = empleado.Calendar_Id,
                Role_Id = empleado.Role_Id,
                Employee_Code = empleado.Employee_Code,
                Password = empleado.Password,
                Email = empleado.Email,
                
            };
        }
    }
}
