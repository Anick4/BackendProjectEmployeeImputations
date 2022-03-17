namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class ProjectDto
    {
        public int Project_Id { get; set; }
        public Boolean State { get; set; }
        public Boolean Generic { get; set; }
        public string? Name { get; set; }
        public int Responsible_Id { get; set; }
    }
}
