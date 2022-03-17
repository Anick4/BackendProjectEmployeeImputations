using Imputaciones.Application.BusinessModel.Response;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ProjectResponse : BaseResponse
    {
        public ProjectResponse() { }
        public ProjectResponse(string message, bool status) : base(message, status) { }
        public int Project_Id { get; set; }
        public bool State { get; set; }
        public bool Generic { get; set; }
        public string? Name { get; set; }
        public int Responsible_Id { get; set; }
    }
}
