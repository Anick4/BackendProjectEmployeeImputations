using Imputaciones.Application.BusinessModel.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Models
{
    public class ImputationResponseModel
    {
        public int EmployeeId { get; set; }
        public string? ProjectName { get; set; }
        public int Projects_Id { get; set; }
        public List<ImputationResponseBase>? Imputations { get; set; }
    }
}
