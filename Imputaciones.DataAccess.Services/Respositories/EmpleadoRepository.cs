using Imputaciones.DataAccess.Contracts.Dtos;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Mappers;
using Imputaciones.DataAccess.Contracts.Repositories;
using Imputaciones.DataAccess.Services.Repositories;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class EmpleadoRepository : GenericRepository<Empleado>, IEmpleadoRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public EmpleadoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<(EmpleadoDto, CalendarioDto, RolDto)> GetEmpleado(int id)
        {
            var resultEntity = await _dbContext.empleados.FindAsync(id);
            
            var resultCalendario = await _dbContext.calendarios.FindAsync(resultEntity.Calendarios_idCalendarios);

            var resultRol = await _dbContext.roles.FindAsync(resultEntity.Roles_idRoles1);

            _dbContext.SaveChanges();

            return (resultEntity.ToEmpleadoDtoMapper(), resultCalendario.ToCalendarioDtoMapper(), resultRol.ToRolDtoMapper());
        }

        public async Task<EmpleadoDto> GetEmpleadoByEmail(string email)
        {
            try
            {
                var result =  _dbContext.empleados.First(x => x.Email == email).ToEmpleadoDtoMapper();
                return result;
                

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
