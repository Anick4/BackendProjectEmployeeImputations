using Imputaciones.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class EmpleadoResponse : BaseResponse
    {
        public EmpleadoResponse() { }
        public EmpleadoResponse(string message, bool status) : base(message, status) { }
        
        public int EmpleadoId { get; set; }

        public string? Codigo_empleado { get; set; }

        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }

        public string? Email { get; set; }

        public string? Contraseña { get; set; }
        public int? Calendarios_idCalendarios { get; set; }
        public int? Roles_idRoles1 { get; set; }
        // public CalendarioResponse Calendario { get; set; }


    }
}
