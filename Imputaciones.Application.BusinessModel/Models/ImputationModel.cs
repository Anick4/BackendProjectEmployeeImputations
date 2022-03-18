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
        public int Employee_Id { get; set; }
        public int Project_Id { get; set; }
        public string? Date { get; set; }
        public string? ProjectName { get; set; }
    }
}
