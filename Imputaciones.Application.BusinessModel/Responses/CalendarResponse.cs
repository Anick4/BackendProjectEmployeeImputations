using Imputations.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.BusinessModel.Responses
{
    public class CalendarResponse : BaseResponse
    {

        public CalendarResponse() { }
        public CalendarResponse(string message, bool status) : base(message, status) { }

        public int Idcalendarios { get; set; }
        public int? Horas_diarias { get; set; }
        public Boolean? Lunes { get; set; }
        public Boolean? Martes { get; set; }
        public Boolean? Miercoles { get; set; }
        public Boolean? Jueves { get; set; }
        public Boolean? Viernes { get; set; }
        public Boolean? Sabado { get; set; }
        public Boolean? Domingo { get; set; }

    }
}
