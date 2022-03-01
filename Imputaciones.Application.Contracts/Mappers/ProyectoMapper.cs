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
    public static class ProyectoMapper
    {
        public static ProyectoModel toProyectoModel(this Proyecto proyecto)
        {
            return new ProyectoModel()
            {
                IdProyecto = proyecto.IdProyecto,
                Nombre = proyecto.Nombre,
                Estado = proyecto.Estado,
                Generico = proyecto.Generico,
                Imputaciones_idimputaciones = proyecto.Imputaciones_idimputaciones,
                ResponsableId = proyecto.ResponsableId,
            };
        }

        public static ProyectoResponse toProyectoResponseMapper(this ProyectoModel proyectoModel)
        {
            return new ProyectoResponse()
            {
                IdProyecto = proyectoModel.IdProyecto,
                Nombre = proyectoModel.Nombre,
                Estado = proyectoModel.Estado,
                Generico = proyectoModel.Generico,
                Imputaciones_idimputaciones = proyectoModel.Imputaciones_idimputaciones,
                ResponsableId = proyectoModel.ResponsableId,
            };

        }



    }
}

