using System.ComponentModel.DataAnnotations;

namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Proyecto
    {
        [Key]
        [Required]
        public int IdProyecto { get; set; }

        [Required]
        public int Estado { get; set; }
        [Required]

        public int Generico { get; set; }
        [Required]

        public string? Nombre { get; set; }
        [Required]

        public int Imputaciones_idimputaciones { get; set; }
        [Required]

        public int ResponsableId { get; set; }
    }
}
