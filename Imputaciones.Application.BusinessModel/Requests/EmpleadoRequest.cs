﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Requests
{
    public class EmpleadoRequest
    {
        public string? Codigo_empleado { get; set; }

        public string? Nombre { get; set; }

        public string? Apellidos { get; set; }

        public string? Email { get; set; }

        public string? Contraseña { get; set; }
        public int? Calendarios_idCalendarios { get; set; }
        public int? roles_idRoles1 { get; set; }
        //public CalendarioRequest? Calendario { get; set; }
    }
}
