using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Mappers;
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

        public async Task<(EmpleadoModel, CalendarioModel, RolModel)> GetEmpleado(int id)
        {
            var entityResponse = await _empleadoRepository.GetEmpleado(id);
            return (entityResponse.Item1.toEmpleadoModelMapper(), entityResponse.Item2.toCalendarioModelMapper(), entityResponse.Item3.toRolModelMapper());
        }

        public static Boolean CheckPassword(EmpleadoModel empleado, string password)
        {
            if(empleado.Contraseña == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<EmpleadoModel> CheckLogin(string email, string password)
        {
           
           var empleado = await _empleadoRepository.GetEmpleadoByEmail(email);
           if(empleado != null)
            {
                if(CheckPassword(empleado.toEmpleadoModelMapper(), password))
                {
                    //TOKEN CUTRISIMO ASIN ES LA BIDA
                    var empleadoModel = empleado.toEmpleadoModelMapper();
                    empleadoModel.Token = string.Concat("Soytutoken");
                    return empleadoModel;
                    
                }
                else
                {
                    throw new Exception("Contraseña incorrecta") ;
                }
                
            } 
            else
            {
                throw new Exception("El email no esta en la base de datos");
            }



        }


    }
}