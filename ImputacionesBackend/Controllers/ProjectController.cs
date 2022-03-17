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
                return Ok(result.ToProjectResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new ProjectResponse(ex.Message, false));
            }
        }
    }
}
