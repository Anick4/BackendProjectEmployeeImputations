using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;

namespace Imputaciones.Application
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly IEmpleadoRepository _empleadoRepository;
        public EmpleadoService(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }
        public Task<EmpleadoModel> AddEmpleado(EmpleadoModel empleadoModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmpleadoModel>> GetAllEmpleados()
        {
            var List = await _empleadoRepository.GetAsync();
            return List.ToList().toListEmpleadoModel();
            
        }

        public EmpleadoModel GetEmpleadoById(int id)
        {
            var result = _empleadoRepository.GetByID(id);
            return result.toEmpleadoModel();
        }
    }
}