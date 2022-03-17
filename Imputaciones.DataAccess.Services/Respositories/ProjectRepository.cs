using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ProjectRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
        }

    }
}
