using Imputaciones.Application.BusinessModel.Models;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IEmpleadoService
    {
        Task<List<EmpleadoModel>> GetAllEmpleados();
        EmpleadoModel GetEmpleadoById(int id);
        Task<EmpleadoModel> AddEmpleado(EmpleadoModel empleadoModel);
    }
}
