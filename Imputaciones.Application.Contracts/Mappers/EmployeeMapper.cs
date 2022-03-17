using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class EmployeeMapper
    {
        // List<Employee> -> List<EmployeeModel>
        public static List<EmployeeModel> ToListEmployeeModel(this List<Employee> employees)
        {
            List<EmployeeModel> employeeModelList = new ();
            foreach (var item in employees)
            {
                employeeModelList.Add(item.ToEmployeeModelMapper());
            }
            return employeeModelList;
        }


        // Entity Employee -> EmployeeModel
        public static EmployeeModel ToEmployeeModelMapper(this Employee employee)
        {
            return new EmployeeModel()
            {
                Employee_Id = employee.Employee_Id,
                Name = employee.Name,
                Surname = employee.Surname,
                Employee_Code = employee.Employee_Code,
                Email = employee.Email,
                Password = employee.Password,
                Calendar_Id = employee.Calendar_Id,
                Role_Id = employee.Role_Id
            };
        }


        // EmployeeModel -> EmployeeResponseWithCalendar
        public static EmployeeResponseWithCalendar ToEmployeeResponseMapper(this EmployeeModel employeeModel)
        {
            return new EmployeeResponseWithCalendar()
            {
                Employee_Id = employeeModel.Employee_Id,
                Name = employeeModel.Name,
                Surname = employeeModel.Surname,
                Employee_Code = employeeModel.Employee_Code,
                Email = employeeModel.Email,
                Password = employeeModel.Password,
                Calendar_Id = employeeModel.Calendar_Id,
                Role_Id = employeeModel.Role_Id,
                Token = employeeModel.Token,
                Projects = employeeModel.Reviewer.ToProjectListResponseReviewerMapper()
            };
        }


        // EmployeeDto -> EmployeeModel
        public static EmployeeModel ToEmployeeModelMapper(this EmployeeDto employeeDto)
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
            };
        }
    }
}
