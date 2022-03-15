using Imputaciones.Application.BusinessModel.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.Application.BusinessModel.Models
{
    public class ImputationModel
    {
        public int Imputation_Id { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public StateEnum State { get; set; }
        public int Extra_Hours { get; set; }
        public int Week { get; set; }
        public int Employees_Id { get; set; }
        public int Project_Id { get; set; }

        public DateTime Date { get; set; }
        public string ProjectName { get; set; }

    }

    public class ImputationResponseModel
    {
        public string? ProjectName { get; set; }
        public int Projects_Id { get; set; }
        public List<ImputationResponseBase>? Imputations { get; set; }
    }

}
