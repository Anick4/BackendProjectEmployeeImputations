namespace Imputaciones.Application.BusinessModel.Requests
{
    public class EmployeeRequest
    {
        public string? Employee_Code { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int? Calendar_Id { get; set; }
        public int? Role_Id { get; set; }     
    }
}
