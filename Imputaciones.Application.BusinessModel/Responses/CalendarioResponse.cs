using Cars.Application.BusinessModel.Response;
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
        public CalendarioResponse(string mesagge, bool status) : base(mesagge, status) { }

        public int Id { get; set; }
        public int? HorasDiarias { get; set; }
        public Boolean? Lunes { get; set; }
        public Boolean? Martes { get; set; }
        public Boolean? Miercoles { get; set; }
        public Boolean? Jueves { get; set; }
        public Boolean? Viernes { get; set; }
        public Boolean? Sabado { get; set; }
        public Boolean? Domingo { get; set; }

    }
}
