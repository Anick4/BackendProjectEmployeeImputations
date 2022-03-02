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
    public static class CalendarioMapper
    {
        public static CalendarioDto ToCalendarioDtoMapper(this Calendario calendario)
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

        public static CalendarioModel toCalendarioModelMapper(this CalendarioDto calendarioDto)
        {
            return new CalendarioModel()
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
