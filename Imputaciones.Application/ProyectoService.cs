using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application
{
    public class ProyectoService : IProyectoService
    {
        public Task<ProyectoModel> AddProyecto(ProyectoModel proyectoModel)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProyectoModel>> GetAllProyectos()
        {
            throw new NotImplementedException();
        }

        public ProyectoModel GetProyectoById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
