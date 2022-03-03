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

        public async Task<EmpleadoModel> GetEmpleado(int id)
        {
            var entityResponse = await _empleadoRepository.GetEmpleado(id);
            var empleado = entityResponse.Item1.toEmpleadoModelMapper();
            empleado.Calendario = entityResponse.Item2.toCalendarioModelMapper();
            empleado.Rol= entityResponse.Item3.toRolModelMapper();


            return empleado;
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
                    var empleadoConToken = await GetEmpleado(empleado.EmpleadoId);
                    empleadoConToken.Token = string.Concat("Soytutoken");
                    //Hcerlo igual que en el controller

                    return empleadoConToken;
                    
                }
                else
                {
                    return null ;
                }
                
            } 
            else
            {
                return null;
            }



        }


    }
}