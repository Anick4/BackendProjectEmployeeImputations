
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

        public async Task<int?> CheckCalendar(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            var calendar = await _dbContext.Calendars.FindAsync(employee?.Calendar_Id);
            int? calendarId = calendar?.Calendar_Id;

            return calendarId;
        }

        public async Task<List<TotalHoursDto>> GetDailyHours(int Employeeid, int week) //REVISARLO CON PEDRO
        {
            var queryName = await (from e in _dbContext.Employees
                            where e.Employee_Id == Employeeid
                            select e.Name).ToListAsync();

            var query = (from im in _dbContext.Imputations
                         where im.Week == week && im.Employee_Id == Employeeid
                         group im by im.Day into g
                         select new TotalHoursDto()
                         {
                             EmployeeName = queryName.FirstOrDefault(),
                             TotalHours = g.Select(x => x.Hours).Sum(),
                             Day = g.Key
                         });
                            
            return await query.ToListAsync();
        }

        public async Task<List<ImputationsForReviewDto>> GetImputationsByProject(int ProjectId)
        {
            var query = from im in _dbContext.Imputations
                        where im.Project_Id == ProjectId
                        join e in _dbContext.Employees on im.Employee_Id equals e.Employee_Id
                        join p in _dbContext.Projects on im.Project_Id equals p.Project_Id
                        select new ImputationsForReviewDto()
                        {
                            Date = im.Date,
                            EmployeeName = e.Name,
                            ProjectId = ProjectId,
                            ProjectName = p.Name,
                            Hours = im.Hours,
                            ImputationId = im.Imputation_Id,
                        };
            return await query.ToListAsync();
        }


    }
       
}
