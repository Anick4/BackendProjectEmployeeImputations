using Imputaciones.Application;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  // Ruta: /Calendario
    public class CalendarController : ControllerBase
    {
        // Inyeccion de dependencias (IoC), instancia automaticamente el constructor sin hacer "new" => IUSerServices userServices = new UserServices();
        //Atributo:
        private readonly ICalendarService _calendarService; // private para proteger que no se trapichee

        //Constructor de CalendarioController:
        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        // ENDPOINTs:
        [HttpGet]
        [Route("GetCalendar")]  // Ruta: /Calendario/GetCalendario  
        public ActionResult GetCalendar(int id)
        {
            try
            {

                var calendarResponse = _calendarService.GetCalendar(id);

                return Ok(calendarResponse.toCalendarResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new CalendarResponse(ex.Message, false));
            }
        }



    }
}
