using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repository;

namespace Imputaciones.DataAccess.Contracts.Repositories
{
    public interface IEmployeeRepository : IGenericRespository<Employee>
    {
        public Task<(EmployeeDto, CalendarDto, RoleDto, List<ProjectDto>)> GetEmployee(int id);
        public Task<EmployeeDto> GetEmployeeByEmail(string email);
    }
}
