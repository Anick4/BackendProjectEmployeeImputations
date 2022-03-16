using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Dtos
{

    public class TotalHoursDto
    {
        public string EmployeeName { get; set; }
        public int TotalHours { get; set; }
        public int Day { get; set; }

    }
}
