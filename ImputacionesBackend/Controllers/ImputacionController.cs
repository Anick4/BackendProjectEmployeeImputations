
using Imputaciones.DataAccess.Contracts.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ImputacionesBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImputacionController : ControllerBase
    {
        private readonly IImputacionRepository _imputacionRepository;

        public ImputacionController(IImputacionRepository imputacionRepository)
        {
            _imputacionRepository = imputacionRepository;
        }

        [HttpGet]
        [Route("GetImputaciones")]
        public void hola() { }
    }
}
