using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Imputacion
    {
        [Required]
        public int IdImputaciones { get; set; }
        [Required]

        public int Dia { get; set; }
        [Required]

        public int Horas { get; set; }
        [Required]

        public bool Estado { get; set; }
        [Required]

        public int Extras { get; set; }
        [Required]

        public int Semana { get; set; }
        public int empleados_idempleados1 { get; set; }
        public int proyectos_idproyectos { get; set; }
    }
}
