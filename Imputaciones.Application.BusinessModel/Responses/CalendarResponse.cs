using Imputaciones.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class CalendarResponse : BaseResponse
    {

        public CalendarResponse() { }
        public CalendarResponse(string message, bool status) : base(message, status) { }

        public int Calendar_Id { get; set; }
        public int? Daily_Hours { get; set; }
        public Boolean? Monday { get; set; }
        public Boolean? Tuesday { get; set; }
        public Boolean? Wednesday { get; set; }
        public Boolean? Thursday { get; set; }
        public Boolean Friday { get; set; }
        public Boolean? Saturday { get; set; }
        public Boolean? Sunday { get; set; }

    }
}
