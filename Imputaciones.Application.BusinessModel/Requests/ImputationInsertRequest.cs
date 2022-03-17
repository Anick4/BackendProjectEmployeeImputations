namespace Imputaciones.Application.BusinessModel.Requests
{
    public class ImputationInsertRequest
    {
        public int EmployeeId { get; set; }
        public string? ProjectName { get; set; }
        public int ProjectId { get; set; }
        public List<ImputationInsertRequestBase>? Imputations { get; set; }
    }
}
