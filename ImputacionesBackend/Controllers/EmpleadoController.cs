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
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
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
                return Ok(result.toEmpleadoResponseMapper());
            }
            catch(Exception ex)
            {
                return BadRequest(new EmpleadoResponse(ex.Message, false));
            }
        }

    }
}
