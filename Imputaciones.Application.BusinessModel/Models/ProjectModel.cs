namespace Imputaciones.Application.BusinessModel.Models
{
    public class ProjectModel
    {
        public int Project_Id { get; set; }
        public Boolean State { get; set; }
        public Boolean Generic { get; set; }
        public string? Name { get; set; }
        public int Responsible_Id { get; set; }
    }
}
