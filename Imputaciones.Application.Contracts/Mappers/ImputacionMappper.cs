using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Mappers
{
    public static class ImputacionMappper
    {
        public static List<ImputacionModel> toListImputacionModel(this List<Imputacion> imputaciones)
        {
            List<ImputacionModel> imputacionModelList = new List<ImputacionModel>();
            foreach (var item in imputaciones)
            {
                imputacionModelList.Add(item.toImputacionModel());
            }
            return imputacionModelList;

        }

        public static ImputacionModel toImputacionModel(this Imputacion imputacion)
        {
            return new ImputacionModel()
            {
                Dia = imputacion.Dia,
                Estado = imputacion.Estado,
                Extras = imputacion.Extras,
                empleados_idempleados1 = imputacion.empleados_idempleados1,
                IdImputaciones = imputacion.IdImputaciones,
                Horas = imputacion.Horas,
                proyectos_idproyectos = imputacion.proyectos_idproyectos,
                Semana = imputacion.Semana,
            };
        }

        public static ImputacionResponse toImputacionesResponse(this ImputacionModel imputacion)
        {
            return new ImputacionResponse()
            {
                Dia = imputacion.Dia,
                Estado = imputacion.Estado,
                Extras = imputacion.Extras,
                empleados_idempleados1 = imputacion.empleados_idempleados1,
                IdImputaciones = imputacion.IdImputaciones,
                Horas = imputacion.Horas,
                proyectos_idproyectos = imputacion.proyectos_idproyectos,
                Semana = imputacion.Semana,

            };
        }
    }
}
