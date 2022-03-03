using Imputations.Application.BusinessModel.Models;
using Imputations.DataAccess.Contracts.Dtos;

namespace Imputations.Application.Contracts.Services
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployees();
        EmployeeModel GetEmployeeById(int id);
        Task<EmployeeModel> AddEmployee(EmployeeModel employeeModel);

        public Task<EmployeeModel> GetEmployee(int id);

        public Task<EmployeeModel> CheckLogin(string email, string password);


    }
}
