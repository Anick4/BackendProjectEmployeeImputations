using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ImputationsForReviewResponse
    {
        public int ImputationId { get; set; }
        public string? EmployeeName { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int Hours { get; set; }
        public string? Date { get; set; }
        public StateEnum Status { get; set; }
    }
}
