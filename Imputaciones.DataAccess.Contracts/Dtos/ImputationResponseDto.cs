using Imputaciones.Application.BusinessModel.Responses;

namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class ImputationResponseDto
    {
        public string? ProjectName { get; set; }
        public int ProjectId { get; set; }
        public List<ImputationResponseBase>? Imputations { get; set; }
    }
}
