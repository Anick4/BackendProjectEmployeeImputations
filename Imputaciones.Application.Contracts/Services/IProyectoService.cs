﻿using Imputaciones.Application.BusinessModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.Application.Contracts.Services
{
    public interface IProyectoService
    {
        Task<List<ProyectoModel>> GetAllProyectos();
        ProyectoModel GetProyectoById(int id);
        Task<ProyectoModel> AddProyecto(ProyectoModel proyectoModel);
    }
}