using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;

namespace Imputaciones.Application
{
    public class CalendarioService : ICalendarioService
    {
        
        // Inyeccion de dependencias (IoC), instancia automaticamente el constructor sin hacer "new" (conecta servicio con data access)
        // Propiedades:
        private readonly ICalendarioRepository _calendarioRepository;

        //Contructor
        public CalendarioService(ICalendarioRepository calendarioRepository)
        {
            _calendarioRepository = calendarioRepository;
        }
        

        // Método GET 
        public CalendarioModel GetCalendario(int id)
        {
            var calendario = _calendarioRepository.GetByID(id);
            return calendario.toCalendarioModelMapper();
        }

    }
}
