using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class EmpleadoDto
    {

        public int EmpleadoId { get; set; }

        public string? Codigo_empleado { get; set; }

        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }

        public string? Email { get; set; }

        public string? Contraseña { get; set; }

        public int? Calendarios_idCalendarios { get; set; }
        public int? Roles_idRoles1 { get; set; }

        public Calendario? Calendario { get; set; }
        public string? Token { get; set; }


    }
}
