using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Dtos
{
    public class ProyectoDto
    {
        public int IdProyecto { get; set; }
        public bool Estado { get; set; }
        public bool Generico { get; set; }
        public string? Nombre { get; set; }
        public int Imputaciones_idimputaciones { get; set; }
        public int ResponsableId { get; set; }
    }
}
