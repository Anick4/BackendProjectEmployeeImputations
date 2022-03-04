
using Imputaciones.Application.BusinessModel.Requests;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
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
                return BadRequest(new ImputationResponseBase(ex.Message, false));
            }
        }

        [HttpPost]
        [Route("GetImputationsByEmployeeByWeek")]
         public async Task<ActionResult> GetImputationsByEmployeeByWeek(ImputationRequest imputationRequest)
         {
             try
             {
                var response = await _imputationService.GetImputationsByEmployeeByWeek(imputationRequest.Employee_Id, imputationRequest.Week);
                var imputationsList = response.toImputationsResponse();


                return Ok(imputationsList);
             }
             catch (Exception ex)
             {
                 return BadRequest(new ImputationResponseBase(ex.Message, false));
            }
         }
    } 
}
