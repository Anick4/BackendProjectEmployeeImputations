using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class CalendarMapper
    {

        // Transforma de CalendarioModel -> CalendarioResponse
        public static CalendarResponse toCalendarResponseMapper(this CalendarModel calendarModel)
        {
            return new CalendarResponse()
            {
                Calendar_Id = calendarModel.Calendar_Id,
                Daily_Hours = calendarModel.Daily_Hours,
                Monday = calendarModel.Monday,
                Tuesday = calendarModel.Tuesday,
                Wednesday = calendarModel.Wednesday,
                Thursday = calendarModel.Thursday,
                Friday = calendarModel.Friday,
                Saturday = calendarModel.Saturday,
                Sunday = calendarModel.Sunday,
            };
        }


        // Transforma de  Entity Calendario -> CalendarioModel 
        public static CalendarModel toCalendarModelMapper(this Calendar calendar)
        {
            return new CalendarModel()
            {
                Calendar_Id = calendar.Calendar_Id,
                Daily_Hours = calendar.Daily_Hours,
                Monday = calendar.Monday,
                Tuesday = calendar.Tuesday,
                Wednesday = calendar.Wednesday,
                Thursday = calendar.Thursday,
                Friday = calendar.Friday,
                Saturday = calendar.Saturday,
                Sunday = calendar.Sunday,
            };
        }

    }
}
