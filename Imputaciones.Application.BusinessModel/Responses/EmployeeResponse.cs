using Imputaciones.Application.BusinessModel.Response;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class EmployeeResponse : BaseResponse
    {
        public EmployeeResponse() { }
        public EmployeeResponse(string message, bool status) : base(message, status) { }
        public EmployeeResponse(int employee_Id, string? employee_Code, string? name, string? surname, string? email, int? calendar_Id, int? role_Id) 
        { 
            this.Employee_Id = employee_Id;
            this.Employee_Code = employee_Code!;
            this.Name = name!;
            this.Surname = surname!;
            this.Email = email!;
            this.Calendar_Id = calendar_Id;
            this.Role_Id = role_Id;
        }

        public int Employee_Id { get; set; }
        public string? Employee_Code { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public int? Calendar_Id { get; set; }
        public int? Role_Id { get; set; }
    }
}
