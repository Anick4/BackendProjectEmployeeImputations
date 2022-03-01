
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
        public void hola() { }
    }
}
