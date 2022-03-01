using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProyectoController : ControllerBase
    {
        private readonly IProyectoService _proyectoService;

        public ProyectoController(IProyectoService proyectoService)
        {
            _proyectoService = proyectoService;

        }

        [HttpGet]
        [Route("GetProyectoById")]

        public ActionResult GetProyectoById(int id)
        {
            try
            {
                var result = _proyectoService.GetProyectoById(id);
                return Ok(result.toProyectoResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new ProyectoResponse(ex.Message, false));
            }

        }


    }
}
