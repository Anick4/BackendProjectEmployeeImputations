using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imputaciones.DataAccess.Contracts.Entities
{

    public class Project
    {
        [Key]
        [Required]
        public int Project_Id { get; set; }
        [Required]
        public Boolean State { get; set; }
        [Required]
        public Boolean Generic { get; set; }
        [Required]
        public string Name { get; set; }      
        [ForeignKey(nameof(Responsible))]
        [Required]
        public int Responsible_Id { get; set; }
        public virtual Employee Responsible { get; set; }
    }
}
