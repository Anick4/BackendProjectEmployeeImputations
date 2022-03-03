using Imputations.DataAccess.Contracts.Dtos;
using Imputations.DataAccess.Contracts.Entities;
using Imputations.DataAccess.Contracts.Mappers;
using Imputations.DataAccess.Contracts.Repositories;
using Imputations.DataAccess.Services.Repositories;

namespace Imputations.DataAccess.Services.Respositories
{
    public class EmpleadoRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmpleadoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<(EmployeeDto, CalendarDto, RoleDto)> GetEmployee(int id)
        {
            var resultEntity = await _dbContext.employees.FindAsync(id);
            
            var resultCalendar = await _dbContext.calendars.FindAsync(resultEntity.Calendar_Id);

            var resultRole = await _dbContext.roles.FindAsync(resultEntity.Role_Id);

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
