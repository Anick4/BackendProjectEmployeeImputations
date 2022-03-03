using Imputations.DataAccess.Services.Repositories;
using Imputations.DataAccess.Contracts.Entities;
using Imputations.DataAccess.Contracts.Repositories;

namespace Imputations.DataAccess.Services.Respositories
{
    public class CalendarioRepository : GenericRepository<Calendar>, ICalendarRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CalendarRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }
    }
}
