using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Imputaciones.Application.BusinessModel.Models.Enums;

namespace Imputaciones.DataAccess.Contracts.Entities
{


    public class Imputation
    {
        [Key]
        [Required]
        public int Imputation_Id { get; set; }
        [Required]
        public int Day { get; set; }
        [Required]
        public int Hours { get; set; }
        [Required]      
        public StateEnum State { get; set; } 
        public int Extra_Hours { get; set; }
        [Required]
        public int Week { get; set; }
        [ForeignKey(nameof(Employee))]
        [Required]
        public int Employee_Id { get; set; }
        public virtual Employee Employee { get; set; }
        [ForeignKey(nameof(Project))]
        [Required]
        public int Project_Id { get; set; }
        public virtual Project Project { get; set; }        
        public DateTime Date { get; set; }
    }
}
