using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ImputationsForReviewResponse
    {
        public int ImputationId { get; set; }

        public string EmployeeName { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int Hours { get; set; }
        public string Date { get; set; }
    }
}
