using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Repositories
{
    public interface IEmployeeRepository : IGenericRespository<Employee>
    {
        public Task<(EmployeeDto, CalendarDto, RoleDto)> GetEmployee(int id);

        public Task<EmployeeDto> GetEmployeeByEmail(string email);

    }
}
