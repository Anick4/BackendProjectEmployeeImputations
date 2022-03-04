using Imputaciones.DataAccess.Services.Repositories;
using Imputaciones.DataAccess.Contracts.Entities;
using Imputaciones.DataAccess.Contracts.Repositories;

namespace Imputaciones.DataAccess.Services.Respositories
{
    public class CalendarioRepository : GenericRepository<Calendar>, ICalendarRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CalendarioRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
