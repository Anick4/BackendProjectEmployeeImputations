using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class CalendarController : ControllerBase
    {
        private readonly ICalendarService _calendarService;

        public CalendarController(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }


        [HttpGet]
        [Route("GetCalendar")] 
        public ActionResult GetCalendar(int id)
        {
            try
            {
                var calendarResponse = _calendarService.GetCalendar(id);

                return Ok(calendarResponse.ToCalendarResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new CalendarResponse(ex.Message, false));
            }
        }
    }
}
