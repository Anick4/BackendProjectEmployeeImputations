using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Requests;
using Imputaciones.Application.BusinessModel.Response;
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
            catch (Exception ex)
            {
                return BadRequest(new EmpleadoResponse(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetEmpleado")]
        public async Task<EmpleadoResponseConCalendario> GetEmpleado(int id)
        {
            try
            {
                var result = await _empleadoService.GetEmpleado(id);
                var empleado = result.Item1.toEmpleadoResponseMapper2();
                empleado.Calendario = result.Item2.toCalendarioResponseMapper();
                empleado.Rol = result.Item3.toRolResponseMapper();


                return empleado;

            }
            catch 
            {
                throw new Exception();
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginRequest loginRequest)
        {
            try
            {
                var response = await _empleadoService.CheckLogin(loginRequest.Email, loginRequest.Password);
                
                var empleado = await GetEmpleado((int)response.EmpleadoId);
                //IDEA PARA TOKEN CREAR FUNCION EN EL SERVICE Y LLAMARLA DESDE AQUI
              

                return Ok(empleado);
            }
            catch (Exception)
            {
                return BadRequest(new BaseResponse("Usuario o Contraseña incorrectos", false));
            }
        }
    }
}
