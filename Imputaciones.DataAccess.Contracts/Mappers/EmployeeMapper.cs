using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class EmployeeMapper
    {
        // EmployeeDto -> Entity Employee
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


        // Entity Employee -> EmployeeDto
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


        // EmployeeDto -> EmployeeModel
        public static EmployeeModel toEmployeeModelMapper(this EmployeeDto employeeDto)
        {
            return new EmployeeModel()
            {
                Employee_Id = employeeDto.Employee_Id,
                Name = employeeDto.Name,
                Surname = employeeDto.Surname,
                Employee_Code = employeeDto.Employee_Code,
                Email = employeeDto.Email,
                Calendar_Id = employeeDto.Calendar_Id,
                Role_Id = employeeDto.Role_Id,
                Calendar = null,
                Role = null
            };
        }
    }   
}
