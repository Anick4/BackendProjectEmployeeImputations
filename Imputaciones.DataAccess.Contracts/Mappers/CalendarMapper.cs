using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class CalendarMapper
    {
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
                Sunday = calendar.Sunday,
            };

        }

        public static CalendarModel toCalendarModelMapper(this CalendarDto calendarDto)
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
