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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;

        }


        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task<ActionResult> GetAllEmployes()
        {
            try
            {
                var result = await _employeeService.GetAllEmployees();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new EmployeeResponse(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetEmployeeById")]
        public ActionResult GetEmpleadoById(int id)
        {
            try
            {
                var result = _employeeService.GetEmployeeById(id);
                return Ok(result.ToEmployeeResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new EmployeeResponse(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetEmployee")]
        public async Task<ActionResult> GetEmployee(int id) 
        {
            try
            {
                var result = await _employeeService.GetEmployee(id);

                return Ok(result.ToEmployeeResponseMapper());
            }
            catch(Exception ex)
            {
                return BadRequest(new EmployeeResponse(ex.Message, false));
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginRequest loginRequest)
        {
            try
            {
                var response = await _employeeService.CheckLogin(loginRequest.Email, loginRequest.Password);
                if (response == null)
                {
                    return Unauthorized();
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest(new BaseResponse("Wrong User or Password", false));
            }
        }
    }
}
