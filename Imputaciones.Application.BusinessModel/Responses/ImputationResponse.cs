﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ImputationResponse 
    {
        
        public string? ProjectName { get; set; }
        public int ProjectId { get; set; }
        public List<ImputationResponseBase>? Imputations { get; set; }
        
    }
}
