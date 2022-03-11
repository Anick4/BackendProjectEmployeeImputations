using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Calendar
    {
        [Key]
        [Required]
        public int Calendar_Id { get; set; }
        [Required]
        public int Daily_Hours { get; set; }
        [Required]
        public Boolean Monday { get; set; }
        [Required]
        public Boolean Tuesday { get; set; }
        [Required]
        public Boolean Wednesday { get; set; }
        [Required]
        public Boolean Thursday { get; set; }
        [Required]
        public Boolean Friday { get; set; }
        [Required]
        public Boolean Saturday { get; set; }
        [Required]
        public Boolean Sunday { get; set; }

        

    }
}
