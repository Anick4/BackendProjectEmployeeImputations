
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImputacionController : ControllerBase
    {
        private readonly IImputacionService _imputacionService;

        public ImputacionController(IImputacionService imputacionService)
        {
            _imputacionService = imputacionService;
        }

        [HttpGet]
        [Route("GetImputaciones")]
        public async Task<ActionResult> GetImputaciones()
        {
            try
            {

            var response = await _imputacionService.GetAllImputaciones();
            return Ok(response);
            } 
            catch (Exception ex)
            {
                return BadRequest(new ImputacionResponse(ex.Message, false));
            }
        }
    }
}
