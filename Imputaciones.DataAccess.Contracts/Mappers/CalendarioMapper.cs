using Imputations.Application.BusinessModel.Models;
using Imputations.DataAccess.Contracts.Dtos;
using Imputations.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputations.DataAccess.Contracts.Mappers
{
    public static class CalendarioMapper
    {
        public static CalendarioDto ToCalendarioDtoMapper(this Calendar calendario)
        {
            return new CalendarioDto()
            {

                Idcalendarios = calendario.Idcalendarios,
                Horas_Diarias = calendario.Horas_diarias,
                Lunes = calendario.Lunes,
                Martes = calendario.Martes,
                Miercoles = calendario.Miercoles,
                Jueves = calendario.Jueves,
                Viernes = calendario.Viernes,
                Sabado = calendario.Sabado,
                Domingo = calendario.Domingo,
            };

        }

        public static CalendarModel toCalendarioModelMapper(this CalendarioDto calendarioDto)
        {
            return new CalendarModel()
            {

                Idcalendarios = calendarioDto.Idcalendarios,
                Horas_diarias = calendarioDto.Horas_Diarias,
                Lunes = calendarioDto.Lunes,
                Martes = calendarioDto.Martes,
                Miercoles = calendarioDto.Miercoles,
                Jueves = calendarioDto.Jueves,
                Viernes = calendarioDto.Viernes,
                Sabado = calendarioDto.Sabado,
                Domingo = calendarioDto.Domingo,
            };
        }

    }
}
