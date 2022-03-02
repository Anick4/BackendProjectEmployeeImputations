using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.DataAccess.Contracts.Dtos;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IEmpleadoService
    {
        Task<List<EmpleadoModel>> GetAllEmpleados();
        EmpleadoModel GetEmpleadoById(int id);
        Task<EmpleadoModel> AddEmpleado(EmpleadoModel empleadoModel);

        public Task<(EmpleadoModel, CalendarioModel, RolModel)> GetEmpleado(int id);

        public Task<EmpleadoModel> CheckLogin(string email, string password);


    }
}
