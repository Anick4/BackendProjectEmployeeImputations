namespace Imputaciones.Application.BusinessModel.Requests
{
    public class ProjectRequest
    {
        public int Project_Id { get; set; }
        public int State { get; set; }
        public int Generic { get; set; }
        public string? Name { get; set; }
        public int Responsible_Id { get; set; }
    }
}

