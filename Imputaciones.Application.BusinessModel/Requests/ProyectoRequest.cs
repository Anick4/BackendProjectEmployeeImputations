using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.BusinessModel.Requests
{
    public class ProyectoRequest
    {
        public int IdProyecto { get; set; }
        public bool Estado { get; set; }
        public bool Generico { get; set; }
        public string? Nombre { get; set; }
        public int Imputaciones_idimputaciones { get; set; }
        public int ResponsableId { get; set; }
    }
}
