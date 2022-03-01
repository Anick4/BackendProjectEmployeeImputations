using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;
        private readonly ICalendarioService _calendarioService;
        public EmpleadoController(IEmpleadoService empleadoService, ICalendarioService calendarioService)
        {
            _empleadoService = empleadoService;
            _calendarioService = calendarioService;
        }

        [HttpGet]
        [Route("GetAllEmpleados")]
        public async Task<ActionResult> GetAllEmpleados()
        {
            try
            {
                var result = await _empleadoService.GetAllEmpleados();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new EmpleadoResponse(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetEmpleadoById")]
        public ActionResult GetEmpleadoById(int id)
        {
            try
            {
                var result = _empleadoService.GetEmpleadoById(id);
                //NO FUNCIONA, PERO NO SE ME OCURRE OTRA COSA
               //var resultCalendario = _calendarioService.GetCalendario((int)result.Calendarios_idCalendarios);
               //result.Calendario = new CalendarioModel() { 
               //    Horas_diarias = result.Calendario.Horas_diarias, 
               //    Domingo = result.Calendario.Domingo, 
               //    Idcalendarios = result.Calendario.Idcalendarios, 
               //    Lunes = result.Calendario.Lunes,
               //    Martes = result.Calendario.Martes,
               //    Miercoles = result.Calendario.Miercoles,
               //    Jueves = result.Calendario.Jueves,
               //    Viernes = result.Calendario.Viernes,
               //    Sabado = result.Calendario.Sabado,
               //};
                
                
               

                return Ok(result.toEmpleadoResponseMapper());
            }
            catch(Exception ex)
            {
                return BadRequest(new EmpleadoResponse(ex.Message, false));
            }
        }

    }
}
