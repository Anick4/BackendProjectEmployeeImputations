
using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;
using Imputaciones.DataAccess.Contracts.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Imputaciones.Application.BusinessModel.Responses;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class ImputationRepository: GenericRepository<Imputation>, IImputationRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ImputationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<List<ImputationResponseDto>> GetImputationsWithProjectByEmployeeByWeek(int id, int week) {

            var query = from ep in _dbContext.Employees_projects
                        join p in _dbContext.Projects on ep.Project_Id equals p.Project_Id

                        where ep.Employee_Id == id

                        select new ImputationResponseDto()
                        {
                            ProjectName = p.Name,
                            ProjectId = p.Project_Id,
                            Imputations = (from im in _dbContext.Imputations where im.Project_Id == ep.Project_Id && im.Employee_Id == ep.Employee_Id && im.Week == week
                                           select new ImputationResponseBase {
                                               Day = im.Day,
                                               State = im.State,
                                               Extra_Hours = im.Extra_Hours,
                                               Hours = im.Hours,
                                               Imputation_Id = im.Imputation_Id,
                                               Week = week,
                                               Status = null,

                                           }).OrderBy(x => x.Day).ToList()
           
                        };
           return await query.OrderBy(x => x.ProjectId).ToListAsync();

            

        }

    }
       
}
