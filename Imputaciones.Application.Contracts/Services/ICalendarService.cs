using Imputaciones.Application.BusinessModel.Models;

namespace Imputaciones.Application.Contracts.Services
{
    public interface ICalendarService
    {
        public CalendarModel GetCalendar(int id);
    }
}
