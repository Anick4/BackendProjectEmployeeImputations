using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Entities;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class CalendarioMapper
    {

        // Transforma de CalendarioModel -> CalendarioResponse
        public static CalendarioResponse toCalendarioResponseMapper(this CalendarioModel calendarioModel)
        {
            return new CalendarioResponse()
            {
                Idcalendarios = calendarioModel.Idcalendarios,
                Horas_diarias = calendarioModel.Horas_diarias,
                Lunes = calendarioModel.Lunes,
                Martes = calendarioModel.Martes,
                Miercoles = calendarioModel.Miercoles,
                Jueves = calendarioModel.Jueves,
                Viernes = calendarioModel.Viernes,
                Sabado = calendarioModel.Sabado,
                Domingo = calendarioModel.Domingo,
            };
        }


        // Transforma de  Entity Calendario -> CalendarioModel 
        public static CalendarioModel toCalendarioModelMapper(this Calendario calendario)
        {
            return new CalendarioModel()
            {
                Idcalendarios = calendario.Idcalendarios,
                Horas_diarias = calendario.Horas_diarias,
                Lunes = calendario.Lunes,
                Martes = calendario.Martes,
                Miercoles = calendario.Miercoles,
                Jueves = calendario.Jueves,
                Viernes = calendario.Viernes,
                Sabado = calendario.Sabado,
                Domingo = calendario.Domingo,
            };
        }

    }
}
