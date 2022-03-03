﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Entities
{
    public class Rol
    {
        [Key]
        [Required]
        public int IdRol { get; set; }
        public string Name { get; set; }
    }
}
