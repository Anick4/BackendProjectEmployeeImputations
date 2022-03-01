using System.ComponentModel.DataAnnotations;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Proyecto
    {
        [Required]
        public int IdProyecto { get; set; }

        [Required]
        public bool Estado { get; set; }
        [Required]

        public bool Generico { get; set; }
        [Required]

        public string? Nombre { get; set; }
        [Required]

        public int Imputaciones_idimputaciones { get; set; }
        [Required]

        public int ResponsableId { get; set; }
    }
}
