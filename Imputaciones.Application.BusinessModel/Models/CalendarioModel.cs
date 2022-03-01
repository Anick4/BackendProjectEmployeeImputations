using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Models
{
    public class CalendarioModel
    {
        public int Idcalendarios { get; set; }
        public int? Horas_diarias { get; set; }
        public int? Lunes { get; set; }
        public int? Martes { get; set; }
        public int? Miercoles { get; set; }
        public int? Jueves { get; set; }
        public int? Viernes { get; set; }
        public int? Sabado { get; set; }
        public int? Domingo { get; set; }

    }
}
