﻿using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Contracts.Mappers
{
    public static class ImputationMapper
    {
        public static ImputationDto ToImputationDtoMapper(this Imputation imputacion)
        {
            return new ImputationDto()
            {
                Day = imputacion.Day,
                Extra_Hours = imputacion.Extra_Hours,
                Hours = imputacion.Hours,
                Imputation_Id = imputacion.Imputation_Id,
                State = imputacion.State,
                Week = imputacion.Week,
                Employee_Id = imputacion.Employee_Id,
                Project_Id = imputacion.Project_Id,
                
            };
        }

        public static List<ImputationDto> ToImputationDtoMapper(this List<Imputation> imputation)
        {
            List<ImputationDto> result = new ();
            foreach (var item in imputation)
            {
                result.Add(new ImputationDto()
                {
                    Day = item.Day,
                    Extra_Hours = item.Extra_Hours,
                    Hours = item.Hours,
                    Imputation_Id = item.Imputation_Id,
                    State = item.State,
                    Week = item.Week,
                    Employee_Id = item.Employee_Id,
                    Project_Id = item.Project_Id,
                });


            }
            
             return result;

        }
    }
}
