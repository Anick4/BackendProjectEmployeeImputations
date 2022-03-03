using Imputations.Application.BusinessModel.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.Application.BusinessModel.Responses
{
    public class ProjectResponse : BaseResponse
    {
        public ProjectResponse() { }
        public ProjectResponse(string message, bool status) : base(message, status) { }
        public int IdProyecto { get; set; }
        public int Estado { get; set; }
        public int Generico { get; set; }
        public string? Nombre { get; set; }
        public int Imputaciones_idimputaciones { get; set; }
        public int ResponsableId { get; set; }
    }
}
