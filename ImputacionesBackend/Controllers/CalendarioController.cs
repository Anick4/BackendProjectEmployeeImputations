using Imputaciones.Application;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // Ruta: /Calendario
    public class CalendarioController : ControllerBase
    {
        // Inyeccion de dependencias (IoC), instancia automaticamente el constructor sin hacer "new" => IUSerServices userServices = new UserServices();
        //Atributo:
        private readonly ICalendarioService _calendarioService; // private para proteger que no se trapichee

        //Constructor de CalendarioController:
        public CalendarioController(CalendarioService calendarioService)
        {
            _calendarioService = calendarioService;
        }

        // ENDPOINTs:
        [HttpGet]
        [Route("GetCalendario")]  // Ruta: /Calendario/GetCalendario  
        public ActionResult GetCalendario(int id)
        {
            var calendarioResponse = _calendarioService.GetCalendario(id);

            return Ok(calendarioResponse.toCalendarioResponseMapper());
        }



    }
}
