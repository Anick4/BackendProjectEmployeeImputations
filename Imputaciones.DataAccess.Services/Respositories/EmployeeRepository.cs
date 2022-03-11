using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Mappers;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        

        public async Task<(EmployeeDto, CalendarDto, RoleDto)> GetEmployee(int id)
        {
            var resultEntity = await _dbContext.Employees.FindAsync(id);

           var resultCalendar = await _dbContext.Calendars.FindAsync(resultEntity.Calendar_Id);
           var resultRol = await _dbContext.Roles.FindAsync(resultEntity.Role_Id);

            _dbContext.SaveChanges();

            return (resultEntity.ToEmployeeDtoMapper(), resultCalendar.ToCalendarDtoMapper(), resultRol.ToRoleDtoMapper());
        }

        public async Task<EmployeeDto> GetEmployeeByEmail(string email)
        {
            try
            {
                var result =  _dbContext.Employees.First(x => x.Email == email).ToEmployeeDtoMapper();

                
                return result;
                

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
