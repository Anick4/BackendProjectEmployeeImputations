using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
   
        public int Hours { get; set; }


        [Required]
        
        public StateEnum State { get; set; }
       
        [Required]
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

        public DateOnly Date { get; set; }
    }
}
