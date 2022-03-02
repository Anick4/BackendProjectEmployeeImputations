using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class EmpleadoResponseConCalendario : EmpleadoResponse
    {
        public EmpleadoResponseConCalendario() { }
        public EmpleadoResponseConCalendario
            (int empleadoId, string? codigo_empleado, string? nombre, string? apellidos, string? email, string? contraseña, int? calendarios_idCalendarios, int? roles_idRoles1) 
            : base(empleadoId, codigo_empleado, nombre, apellidos, email, contraseña, calendarios_idCalendarios, roles_idRoles1) { }
        public CalendarioResponse? Calendario { get; set; }
        public RolResponse? Rol { get; set; }

        public string Token { get; set; }
        
        
    }
}
