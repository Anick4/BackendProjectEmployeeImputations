using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Application.BusinessModel.Response
{
    public class BaseResponse
    {
        public BaseResponse() { }
        public BaseResponse(string messagge, bool status) 
        { 
            this.Message = messagge;
            this.Status = status;
        }
        public string? Message { get; set; }
        public bool? Status { get; set; }
    }
}
