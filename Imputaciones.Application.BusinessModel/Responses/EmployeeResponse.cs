using Imputations.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.BusinessModel.Responses
{
    public class EmployeeResponse : BaseResponse
    {
        public EmployeeResponse() { }
        public EmployeeResponse(string message, bool status) : base(message, status) { }
        public EmployeeResponse(int empleadoId, string? codigo_empleado, string? nombre, string? apellidos, string? email, string? contraseña, int? calendarios_idCalendarios, int? roles_idRoles1) 
        { 
            this.Employee_Id = empleadoId;
            this.Employee_Code = codigo_empleado;
            this.Name = nombre;
            this.Surname = apellidos;
            this.Email = email;
            this.Password = contraseña;
            this.Calendar_Id = calendarios_idCalendarios;
            this.Roles_idRoles1 = roles_idRoles1;
        
        
        
        }


        public int Employee_Id { get; set; }

        public string? Employee_Code { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
        public int? Calendar_Id { get; set; }
        public int? Roles_idRoles1 { get; set; }


    }
}
