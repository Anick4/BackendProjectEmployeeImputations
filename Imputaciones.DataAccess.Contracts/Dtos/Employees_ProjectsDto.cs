﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class Employees_ProjectsDto
    {
        public int Employees_Projects_Id { get; set; }
        public int Employee_Id { get; set; }
        public int Project_Id { get; set; }
    }
}
