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
    public static class EmployeeMapper
    {
        public static Employee ToEmployeeMapper(this EmployeeDto employeeDto)
        {
            return new Employee()
            {
                Employee_Id = employeeDto.Employee_Id,
                Name = employeeDto.Name,
                Surname = employeeDto.Surname,
                Calendar_Id = employeeDto.Calendar_Id,
                Role_Id = employeeDto.Role_Id,
                Employee_Code = employeeDto.Employee_Code,
                Password = employeeDto.Password,
                Email = employeeDto.Email,
                Calendar = null,
                Role = null
                
                
            };
        }

        public static EmployeeDto ToEmployeeDtoMapper(this Employee employee)
        {
            return new EmployeeDto
            {
                Employee_Id = employee.Employee_Id,
                Name = employee.Name,
                Surname = employee.Surname,
                Calendar_Id = employee.Calendar_Id,
                Role_Id = employee.Role_Id,
                Employee_Code = employee.Employee_Code,
                Password = employee.Password,
                Email = employee.Email

            };

        }

        public static EmployeeModel toEmployeeModelMapper(this EmployeeDto employeeDto)
        {
            return new EmployeeModel()
            {
                Employee_Id = employeeDto.Employee_Id,
                Name = employeeDto.Name,
                Surname = employeeDto.Surname,
                Employee_Code = employeeDto.Employee_Code,
                Email = employeeDto.Email,
                Password = employeeDto.Password,
                Calendar_Id = employeeDto.Calendar_Id,
                Role_Id = employeeDto.Role_Id,
                Calendar = null,
                Role = null
            };
        }
    }   
}
