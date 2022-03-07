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
            var resultEntity = await _dbContext.employees.FindAsync(id);
            
            var resultCalendar = await _dbContext.calendars.FindAsync(resultEntity.Calendar_Id);

            var resultRol = await _dbContext.roles.FindAsync(resultEntity.Role_Id);

            _dbContext.SaveChanges();

            return (resultEntity.ToEmployeeDtoMapper(), resultCalendar.ToCalendarDtoMapper(), resultRol.ToRolDtoMapper());
        }

        public async Task<EmployeeDto> GetEmployeeByEmail(string email)
        {
            try
            {
                var result =  _dbContext.employees.First(x => x.Email == email).ToEmployeeDtoMapper();

                
                return result;
                

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
