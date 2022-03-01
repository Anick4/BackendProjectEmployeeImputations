using System.ComponentModel.DataAnnotations;


namespace Imputaciones.DataAccess.Contracts.Entities
{
    public class Empleado 
    {
        [Required]
        public int EmpleadoId { get; set; }

        [Required]
        public string? Codigo_empleado { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public string? Apellidos { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Contraseña { get; set; }
        [Required]

        public int? Calendarios_idCalendarios { get; set; }
        public int? roles_idRoles1 { get; set; }
        //public Calendario? Calendario { get; set; }




    }
}
