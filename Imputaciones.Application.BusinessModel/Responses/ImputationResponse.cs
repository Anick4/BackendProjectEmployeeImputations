namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ImputationResponse 
    {     
        public string? ProjectName { get; set; }
        public int ProjectId { get; set; }
        public List<ImputationResponseBase>? Imputations { get; set; }      
    }
}
