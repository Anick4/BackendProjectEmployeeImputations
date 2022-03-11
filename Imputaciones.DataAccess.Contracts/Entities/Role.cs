using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
