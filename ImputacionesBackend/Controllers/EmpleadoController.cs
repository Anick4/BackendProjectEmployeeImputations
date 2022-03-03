using Imputations.Application.BusinessModel.Models;
using Imputations.Application.BusinessModel.Requests;
using Imputations.Application.BusinessModel.Response;
using Imputations.Application.BusinessModel.Responses;
using Imputations.Application.Contracts.Mappers;
using Imputations.Application.Contracts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ImputationsBackend.Controllers
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
                return BadRequest(new EmployeesResponse(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetEmployeeById")]
        public ActionResult GetEmpleadoById(int id)
        {
            try
            {
                var result = _employeeService.GetEmployeeById(id);
                return Ok(result.toEmpleadoResponseMapper());
            }
            catch (Exception ex)
            {
                return BadRequest(new EmployeeResponse(ex.Message, false));
            }
        }

        [HttpGet]
        [Route("GetEmployee")]
        public async Task<ActionResult> GetEmployee(int id) //NOMBRE CAMBIADO
        {
            try
            {
                var result = await _employeeService.GetEmployee(id);

                return Ok(result);

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
                var response = await _employeeService.CheckLogin(loginRequest.Email, loginRequest.Password);


                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest(new BaseResponse("Wrong User or Password", false));
            }
        }
    }
}
