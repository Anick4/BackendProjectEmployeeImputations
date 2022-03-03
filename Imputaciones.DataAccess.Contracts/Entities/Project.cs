﻿using System.ComponentModel.DataAnnotations;

namespace Imputations.DataAccess.Contracts.Entities
{
    public class Project
    {
        [Key]
        [Required]
        public int Project_Id { get; set; }

        [Required]
        public int State { get; set; }
        [Required]

        public int Generic { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]

        public int Imputaciones_idimputaciones { get; set; }
        [Required]

        public int Responsible_Id { get; set; }
    }
}
