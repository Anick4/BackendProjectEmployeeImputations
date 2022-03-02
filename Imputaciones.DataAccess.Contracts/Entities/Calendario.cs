using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Calendario
    {
        [Key]
        [Required]
        public int Idcalendarios { get; set; }
        [Required]
        public int? Horas_diarias { get; set; }
        [Required]
        public int? Lunes { get; set; }
        [Required]
        public int? Martes { get; set; }
        [Required]
        public int? Miercoles { get; set; }
        [Required]
        public int? Jueves { get; set; }
        [Required]
        public int? Viernes { get; set; }
        [Required]
        public int? Sabado { get; set; }
        [Required]
        public int? Domingo { get; set; }
    }
}
