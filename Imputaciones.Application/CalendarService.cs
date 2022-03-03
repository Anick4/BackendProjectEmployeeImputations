using Imputations.Application.BusinessModel.Models;
using Imputations.Application.Contracts.Mappers;
using Imputations.Application.Contracts.Services;
using Imputations.DataAccess.Contracts.Repositories;

namespace Imputations.Application
{
    public class CalendarService : ICalendarService
    {
        
        // Inyeccion de dependencias (IoC), instancia automaticamente el constructor sin hacer "new" (conecta servicio con data access)
        // Propiedades:
        private readonly ICalendarRepository _calendarRepository;

        //Contructor
        public CalendarService(ICalendarRepository calendarRepository)
        {
            _calendarRepository = calendarRepository;
        }
        

        // Método GET 
        public CalendarModel GetCalendar(int id)
        {
            var calendar = _calendarRepository.GetByID(id);
            return calendar.toCalendarModelMapper();
        }

    }
}
