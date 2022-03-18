namespace Imputaciones.Application.BusinessModel.Responses
{
    public class EmployeeResponseWithCalendar : EmployeeResponse
    {
        public EmployeeResponseWithCalendar() { }
        public EmployeeResponseWithCalendar
            (int employee_Id, string? employee_Code, string? name, string? surname, string? email, int? calendar_Id, int? role_Id) 
            : base(employee_Id, employee_Code, name, surname, email, calendar_Id, role_Id){ }

        public CalendarResponse? Calendar { get; set; }
        public RoleResponse? Role { get; set; }
        public List<ProjectResponseReviewer>? Projects { get; set; }
        public string? Token { get; set; }    
    }
}
