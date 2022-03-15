using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.Application.BusinessModel.Requests
{
    public class ImputationRequest
    {
        public int Week { get; set; }
        
        public int Employee_Id { get; set; }

    }

    public class ImputationInsertRequestBase
    {
        public int Imputation_Id { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public StateEnum State { get; set; }
        public int Extra_Hours { get; set; }
        public int Week { get; set; }
        //public int Employee_Id { get; set; }
        //public int Project_Id { get; set; }
        public string Date { get; set; }
    }
    public class ImputationInsertRequest
    {
        public int EmployeeId{ get; set; }
        public string? ProjectName { get; set; }
        public int ProjectId { get; set; }
        public List<ImputationInsertRequestBase>? Imputations { get; set; }
    }
}
