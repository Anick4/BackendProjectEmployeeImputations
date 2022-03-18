using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.Application.BusinessModel.Requests
{
    public class ImputationInsertRequestBase
    {
        public int Imputation_Id { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public StateEnum State { get; set; }
        public int Extra_Hours { get; set; }
        public int Week { get; set; }
        public string? Date { get; set; }
    }
}
