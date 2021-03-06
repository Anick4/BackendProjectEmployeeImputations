
using Imputaciones.Application.BusinessModel.Requests;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
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
                var response = await _imputationService.GetImputationsWithProjectByEmployeeByWeek(imputationRequest.Employee_Id, imputationRequest.Week);
                var imputationsList = response.ToListImputationsResponse();
                return Ok(imputationsList);
             }
             catch (Exception ex)
             {
                 return BadRequest(new ImputationResponseBase(ex.Message, false));
            }
         }

        [HttpPost]
        [Route("ImputationPost")]
        public async Task<ActionResult> InsertImputation(List<ImputationInsertRequest> imputationList)
        {
            try
            {
                var result = await _imputationService.InsertImputation(imputationList);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(new ImputationResponseBase(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetImputationsByProjectId")]   
        public async Task<ActionResult> GetImputationsByProject(int ProjectId)
        {
            try 
            {
                var result = await _imputationService.GetImputationsByProject(ProjectId);
                return Ok(result.ToListResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new ImputationResponseBase(ex.Message, false));
            }
        }

        [HttpPut]
        [Route("ChangeImputationStatus")]
        public async Task<IResult> ChangeImputationStatus(int id, int status)
        {
            try
            {
                await _imputationService.ChangeImputationStatus(id, status);
                return Results.Ok("Estado cambiado correctamente");
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ImputationResponseBase(ex.Message, false));
            }
        }

        [HttpPut]
        [Route("AproveAllImputations")]
        public async Task<IResult> AproveAllImputations(int ProjectId)
        {
            try
            {
                await _imputationService.AproveAllImputations(ProjectId);
                return Results.Ok("Estado cambiado correctamente");
            }
            catch (Exception ex)
            {
                return Results.BadRequest(new ImputationResponseBase(ex.Message, false));
            }
        }
    } 
}
