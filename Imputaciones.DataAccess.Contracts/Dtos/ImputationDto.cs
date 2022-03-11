using Imputaciones.Application.BusinessModel.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class ImputationDto
    {

        public int Imputation_Id { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public StateEnum State { get; set; }
        public int Extra_Hours { get; set; }
        public int Week { get; set; }
        public int Employee_Id { get; set; }
        public int Project_Id { get; set; }
    }

    public class ImputationResponseDto
    {
        public string? ProjectName { get; set; }
        public int ProjectId { get; set; }
        public List<ImputationResponseBase>? Imputations { get; set; }
    }
}
