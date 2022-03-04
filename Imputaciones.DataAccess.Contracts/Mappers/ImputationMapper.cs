using Imputaciones.DataAccess.Contracts.Dtos;
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
                Employee_Id = imputacion.Employee_Id,
                Extra_Hours = imputacion.Extra_Hours,
                Hours = imputacion.Hours,
                Imputation_Id = imputacion.Imputation_Id,
                Project_Id = imputacion.Project_Id,
                State = imputacion.State,
                Week = imputacion.Week
            };
        }

        public static ImputationDto ToImputationDtoMapper(this List<Imputation> imputacion)
        {
            return new ImputationDto()
            {
                Day = imputacion[0].Day,
                Employee_Id = imputacion[0].Employee_Id,
                Extra_Hours = imputacion[0].Extra_Hours,
                Hours = imputacion[0].Hours,
                Imputation_Id = imputacion[0].Imputation_Id,
                Project_Id = imputacion[0].Project_Id,
                State = imputacion[0].State,
                Week = imputacion[0].Week

            };
        }
    }
}
