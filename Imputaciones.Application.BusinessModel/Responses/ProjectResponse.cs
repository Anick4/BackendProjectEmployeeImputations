using Imputaciones.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Responses
{
    public class ProjectResponse : BaseResponse
    {
        public ProjectResponse() { }
        public ProjectResponse(string message, bool status) : base(message, status) { }
        public int Project_Id { get; set; }
        public bool State { get; set; }
        public bool Generic { get; set; }
        public string? Name { get; set; }
        public int Responsible_Id { get; set; }
    }


}
