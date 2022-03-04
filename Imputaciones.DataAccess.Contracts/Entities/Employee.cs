using System.ComponentModel.DataAnnotations;


namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Employee 
    {
        [Key]
        [Required]
        public int Employee_Id { get; set; }
        [Required]
        public string? Employee_Code { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Surname { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public int? Calendar_Id { get; set; }
        [Required]
        public int? Role_Id { get; set; }

    }
}
