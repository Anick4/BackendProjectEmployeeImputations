using Imputaciones.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ImputationResponseBase : BaseResponse
    {

        public ImputationResponseBase() { }
        public ImputationResponseBase(string message, bool status):  base(message, status) { }

        public int Imputation_Id { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public StateEnum State { get; set; }
        public int Extra_Hours { get; set; }
        public int Week { get; set; }
        
    }
}
