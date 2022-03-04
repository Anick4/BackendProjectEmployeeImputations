using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Mappers;
using Imputaciones.DataAccess.Contracts.Repositories;

namespace Imputaciones.Application
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public Task<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeModel>> GetAllEmployees()
        {
            var List = await _employeeRepository.GetAsync();
            return List.ToList().toListEmployeeModel();

        }

        public EmployeeModel GetEmployeeById(int id)
        {
            var result = _employeeRepository.GetByID(id);
            return result.toEmployeeModel();
        }

        public async Task<EmployeeModel> GetEmployee(int id)
        {
            var entityResponse = await _employeeRepository.GetEmployee(id);
            var employee = entityResponse.Item1.toEmployeeModelMapper();
            employee.Calendar = entityResponse.Item2.toCalendarModelMapper();
            employee.Role = entityResponse.Item3.toRoleModelMapper();


            return employee;
        }

        public static Boolean CheckPassword(EmployeeModel employee, string password)
        {
            if (employee.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<EmployeeModel> CheckLogin(string email, string password)
        {

            var employee = await _employeeRepository.GetEmployeeByEmail(email);
            if (employee != null)
            {
                if (CheckPassword(employee.toEmployeeModelMapper(), password))
                {
                    //TOKEN CUTRISIMO ASIN ES LA BIDA
                    var employeWithToken = await GetEmployee(employee.Employee_Id);
                    employeWithToken.Token = string.Concat("Soytutoken");
                    //Hcerlo igual que en el controller

                    return employeWithToken;

                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }



        }


    }
}