using System.ComponentModel.DataAnnotations;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Role
    {
        [Key]
        [Required]
        public int Role_Id { get; set; }
        [Required]
        public string Role_Name { get; set; }
    }
}
