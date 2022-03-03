using Imputations.Application.BusinessModel.Models;
using Imputations.Application.BusinessModel.Responses;
using Imputations.DataAccess.Contracts.Entities;

namespace Imputations.Application.Contracts.Mappers
{
    public static class CalendarMapper
    {

        // Transforma de CalendarioModel -> CalendarioResponse
        public static CalendarResponse toCalendarResponseMapper(this CalendarModel calendarModel)
        {
            return new CalendarResponse()
            {
                Idcalendarios = calendarModel.Idcalendarios,
                Horas_diarias = calendarModel.Horas_diarias,
                Lunes = calendarModel.Lunes,
                Martes = calendarModel.Martes,
                Miercoles = calendarModel.Miercoles,
                Jueves = calendarModel.Jueves,
                Viernes = calendarModel.Viernes,
                Sabado = calendarModel.Sabado,
                Domingo = calendarModel.Domingo,
            };
        }


        // Transforma de  Entity Calendario -> CalendarioModel 
        public static CalendarModel toCalendarModelMapper(this Calendar calendar)
        {
            return new CalendarModel()
            {
                Idcalendarios = calendar.Idcalendarios,
                Horas_diarias = calendar.Horas_diarias,
                Lunes = calendar.Lunes,
                Martes = calendar.Martes,
                Miercoles = calendar.Miercoles,
                Jueves = calendar.Jueves,
                Viernes = calendar.Viernes,
                Sabado = calendar.Sabado,
                Domingo = calendar.Domingo,
            };
        }

    }
}
