using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class CalendarMapper
    {

        // Transforma de CalendarioModel -> CalendarioResponse
        public static CalendarResponse ToCalendarResponseMapper(this CalendarModel calendarModel)
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
        public static CalendarModel ToCalendarModelMapper(this Calendar calendar)
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

        public static CalendarModel ToCalendarModelMapper(this CalendarDto calendarDto)
        {
            return new CalendarModel()
            {

                Calendar_Id = calendarDto.Calendar_Id,
                Daily_Hours = calendarDto.Daily_Hours,
                Monday = calendarDto.Monday,
                Tuesday = calendarDto.Tuesday,
                Wednesday = calendarDto.Wednesday,
                Thursday = calendarDto.Thursday,
                Friday = calendarDto.Friday,
                Saturday = calendarDto.Saturday,
                Sunday = calendarDto.Sunday,

            };
        }
    }
}
