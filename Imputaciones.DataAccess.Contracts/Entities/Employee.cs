using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Employee 
    {
        [Key]
        [Required]
        public int Employee_Id { get; set; }
        [Required]
        public string Employee_Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
       
        [ForeignKey(nameof(Calendar))]
        [Required]
        public int Calendar_Id { get; set; }
        public virtual Calendar Calendar { get; set; }
        [ForeignKey(nameof(Role))]
        [Required]
        public int Role_Id { get; set; }
        public virtual Role Role { get; set; }

    }
}
