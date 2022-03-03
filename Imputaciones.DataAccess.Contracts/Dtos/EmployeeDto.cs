using Imputations.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Dtos
{
    public class EmployeeDto
    {

        public int Employee_Id { get; set; }

        public string? Employee_Code { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public int? Calendar_Id { get; set; }
        public int? Role_Id { get; set; }

        public CalendarioDto? Calendario { get; set; }
        public RoleDto? Rol { get; set; }
        public string? Token { get; set; }


    }
}
