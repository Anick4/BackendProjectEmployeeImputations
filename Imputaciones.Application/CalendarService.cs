using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;

namespace Imputaciones.Application
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
