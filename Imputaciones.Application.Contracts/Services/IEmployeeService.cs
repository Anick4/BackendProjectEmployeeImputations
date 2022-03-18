using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.DataAccess.Contracts.Dtos;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployees();
        public EmployeeModel GetEmployeeById(int id);
        Task<EmployeeModel> AddEmployee(EmployeeModel employeeModel);
        public Task<EmployeeModel?>? GetEmployee(int? id);

        public Task<EmployeeModel?>? CheckLogin(string email, string password);

    }
}
