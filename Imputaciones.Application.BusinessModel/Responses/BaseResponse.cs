using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Response
{
    public class BaseResponse
    {
        public BaseResponse() { }
        public BaseResponse(string message, bool status) 
        { 
            this.Message = message;
            this.Status = status;
        }
        public string? Message { get; set; }
        public bool? Status { get; set; }
    }
}
