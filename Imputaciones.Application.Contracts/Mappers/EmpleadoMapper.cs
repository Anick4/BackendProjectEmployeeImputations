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
    public static class EmpleadoMapper
    {

        public static List<EmpleadoModel> toListEmpleadoModel(this List<Empleado> empleados)
        {
            List<EmpleadoModel> empleadoModelList = new List<EmpleadoModel>();
            foreach (var item in empleados)
            {
                empleadoModelList.Add(item.toEmpleadoModel());
            }
            return empleadoModelList;
        }

        public static EmpleadoModel toEmpleadoModel(this Empleado empleado)
        {
            return new EmpleadoModel()
            {
                EmpleadoId = empleado.EmpleadoId,
                Nombre = empleado.Nombre,
                Apellidos = empleado.Apellidos,
                Codigo_empleado = empleado.Codigo_empleado,
                Email = empleado.Email,
                Contraseña = empleado.Contraseña,
                Calendarios_idCalendarios = empleado.Calendarios_idCalendarios,
                
                
            };
        }

        public static EmpleadoResponse toEmpleadoResponseMapper(this EmpleadoModel empleadoModel)
        {
            return new EmpleadoResponse()
            {
                EmpleadoId = empleadoModel.EmpleadoId,
                Nombre = empleadoModel.Nombre,
                Apellidos = empleadoModel.Apellidos,
                Codigo_empleado = empleadoModel.Codigo_empleado,
                Email = empleadoModel.Email,
                Contraseña = empleadoModel.Contraseña,
                Calendarios_idCalendarios = empleadoModel.Calendarios_idCalendarios
                
            };
        }

        
    }
}
