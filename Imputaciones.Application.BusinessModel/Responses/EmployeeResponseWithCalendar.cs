using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.BusinessModel.Responses
{
    public class EmployeeResponseWithCalendar : EmployeeResponse
    {
        public EmployeeResponseWithCalendar() { }
        public EmployeeResponseWithCalendar
            (int empleadoId, string? codigo_empleado, string? nombre, string? apellidos, string? email, string? contraseña, int? calendarios_idCalendarios, int? roles_idRoles1) 
            : base(empleadoId, codigo_empleado, nombre, apellidos, email, contraseña, calendarios_idCalendarios, roles_idRoles1) { }
        public CalendarResponse Calendar { get; set; }
        public RoleResponse? Role { get; set; }

        public string Token { get; set; }
        
        
    }
}
