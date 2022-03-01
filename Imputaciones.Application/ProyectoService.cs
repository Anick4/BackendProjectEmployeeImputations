using Imputaciones.Application.BusinessModel.Models;
using Imputaciones.Application.Contracts.Mappers;
using Imputaciones.Application.Contracts.Services;
using Imputaciones.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application
{
    public class ProyectoService : IProyectoService
    {
        private readonly IProyectoRepository _proyectoRepository;
        public ProyectoService(IProyectoRepository proyectoRepository)
        {
            _proyectoRepository = proyectoRepository;
        }
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
            var result = _proyectoRepository.GetByID(id);
            return result.toProyectoModel();
        }
    }
}

