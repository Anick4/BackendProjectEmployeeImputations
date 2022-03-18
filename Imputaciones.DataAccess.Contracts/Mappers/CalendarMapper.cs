using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class CalendarMapper
    {
        // Entity Calendar -> CalendarDto
        public static CalendarDto ToCalendarDtoMapper(this Calendar calendar)
        {
            return new CalendarDto()
            {
                Calendar_Id = calendar.Calendar_Id,
                Daily_Hours = calendar.Daily_Hours,
                Monday = calendar.Monday,
                Tuesday = calendar.Tuesday,
                Wednesday = calendar.Wednesday,
                Thursday = calendar.Thursday,
                Friday = calendar.Friday,
                Saturday = calendar.Saturday,
                Sunday = calendar.Sunday
            };
        }
    }
}
