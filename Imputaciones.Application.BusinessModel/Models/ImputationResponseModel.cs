using Imputaciones.Application.BusinessModel.Responses;

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
