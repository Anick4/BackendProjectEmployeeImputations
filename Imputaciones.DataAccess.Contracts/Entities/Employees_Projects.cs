using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Employees_Projects
    {
        [Key]
        [Required]
        public int Employees_Projects_Id { get; set; }

        [ForeignKey(nameof(Employee))]
        [Required]
        public int Employee_Id { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(Project))]
        [Required]
        public int Project_Id { get; set; }
        public virtual Project Project { get; set; }


    }
}
