namespace Imputaciones.Application.BusinessModel.Models
{
    public class EmployeeModel
    {
        public int Employee_Id { get; set; }
        public string? Employee_Code { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public int Calendar_Id { get; set; }
        public CalendarModel? Calendar { get; set; }
        public int Role_Id { get; set; }
        public RoleModel? Role { get; set; }
        public List<ProjectModelReviewer>? Reviewer { get; set; }
        public string? Token { get; set; } 
    }
}
