using Imputaciones.Application.BusinessModel.Responses;
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProjectRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext ?? throw new ArgumentNullException(nameof(dbcontext));
        }

        public async Task<List<ProjectDto>> GetByEmployeeId(int id) 
        {
            var query = from a in _dbContext.Employees_projects
                        join x in _dbContext.Projects on a.Employee_Id equals id
                        select new ImputationResponse()
                        {
                            ProjectName = x.Name,
                            ProjectId = x.Project_Id,
                            Imputations = null
                        };



           var result2 = _dbContext.Employees_projects.Include(x => x.Employee_Id == id).ToList(); //OOJO
          
           var result = _dbContext.Employees_projects.Where(x => x.Employee_Id == id).ToList();
          
           return null;

           
          
        
        }
    }
}
