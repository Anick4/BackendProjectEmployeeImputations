using Imputaciones.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class CalendarioResponse : BaseResponse
    {

        public CalendarioResponse() { }
        public CalendarioResponse(string message, bool status) : base(message, status) { }

        public int Idcalendarios { get; set; }
        public int? Horas_diarias { get; set; }
        public int? Lunes { get; set; }
        public int? Martes { get; set; }
        public int? Miercoles { get; set; }
        public int? Jueves { get; set; }
        public int? Viernes { get; set; }
        public int? Sabado { get; set; }
        public int? Domingo { get; set; }

    }
}
