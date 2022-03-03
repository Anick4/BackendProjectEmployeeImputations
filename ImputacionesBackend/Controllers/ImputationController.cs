
using Imputations.Application.BusinessModel.Responses;
using Imputations.Application.Contracts.Services;
using Imputations.DataAccess.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImputationsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImputationController : ControllerBase
    {
        private readonly IImputationService _imputationService;

        public ImputationController(IImputationService imputationService)
        {
            _imputationService = imputationService;
        }

        [HttpGet]
        [Route("GetImputations")]
        public async Task<ActionResult> GetImputations()
        {
            try
            {

            var response = await _imputationService.GetAllImputations();
            return Ok(response);
            } 
            catch (Exception ex)
            {
                return BadRequest(new ImputationResponse(ex.Message, false));
            }
        }
    }
}
