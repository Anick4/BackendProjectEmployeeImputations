using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Entities
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

        public string State { get; set; }
        [Required]

        public int Extra_Hours { get; set; }
        [Required]

        public int Week { get; set; }
        public int Employee_Id { get; set; }
        public int Project_Id { get; set; }
    }
}
