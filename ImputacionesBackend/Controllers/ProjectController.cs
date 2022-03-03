using Imputations.Application.BusinessModel.Responses;
using Imputations.Application.Contracts.Mappers;
using Imputations.Application.Contracts.Services;
using Imputations.DataAccess.Contracts.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImputationsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;

        }

        [HttpGet]
        [Route("GetProjectById")]

        public ActionResult GetProjectById(int id)
        {
            try
            {
                var result = _projectService.GetProjectById(id);
                return Ok(result.toProjectResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new ProjectResponse(ex.Message, false));
            }

        }


    }
}
