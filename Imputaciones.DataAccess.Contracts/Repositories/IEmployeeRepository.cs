using Imputations.DataAccess.Contracts.Dtos;
using Imputations.DataAccess.Contracts.Entities;
using Imputations.DataAccess.Contracts.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Repositories
{
    public interface IEmployeeRepository : IGenericRespository<Employee>
    {
        public Task<(EmployeeDto, CalendarioDto, RoleDto)> GetEmployee(int id);

        public Task<EmployeeDto> GetEmployee(string email);

    }
}
