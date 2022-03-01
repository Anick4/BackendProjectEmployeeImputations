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
        [Required]
        public int Id { get; set; }
        [Required]
        public int? HorasDiarias { get; set; }
        [Required]
        public Boolean? Lunes { get; set; }
        [Required]
        public Boolean? Martes { get; set; }
        [Required]
        public Boolean? Miercoles { get; set; }
        [Required]
        public Boolean? Jueves { get; set; }
        [Required]
        public Boolean? Viernes { get; set; }
        [Required]
        public Boolean? Sabado { get; set; }
        [Required]
        public Boolean? Domingo { get; set; }
    }
}
