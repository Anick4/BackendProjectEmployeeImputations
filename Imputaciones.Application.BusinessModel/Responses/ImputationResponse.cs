using Imputations.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.BusinessModel.Responses
{
    public class ImputationResponse : BaseResponse
    {

        public ImputationResponse() { }
        public ImputationResponse(string message, bool status):  base(message, status) { }


        public int IdImputaciones { get; set; }
        public int Dia { get; set; }
        public int Horas { get; set; }
        public string Estado { get; set; }
        public int Extras { get; set; }
        public int Semana { get; set; }
        public int empleados_idempleados1 { get; set; }
        public int proyectos_idproyectos { get; set; }
    }
}
