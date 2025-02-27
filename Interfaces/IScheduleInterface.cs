using Microsoft.EntityFrameworkCore;
using WebApplication1.Databases;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IScheduleService
    {
        public Task<Schedule> GetScheduleAsync(int scheduleId, CancellationToken cancellationToken);
    }

    public class ScheduleService : IScheduleService
    {
        private readonly PrepodDbContext _dbContext;

        public ScheduleService(PrepodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Schedule> GetScheduleAsync(int scheduleId, CancellationToken cancellationToken)
        {
            var schedule = _dbContext.Set<Schedule>().FirstAsync<Schedule>( e => (e.Id == scheduleId), cancellationToken);

            return schedule;
        }
    }
}
