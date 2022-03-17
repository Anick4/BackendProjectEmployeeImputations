using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class ImputationsForReviewDto
    {
        public int ImputationId { get; set; }
        public string EmployeeName { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public int Hours { get; set; }
        public DateTime Date { get; set; }
        public StateEnum Status { get; set; }
    }
}
