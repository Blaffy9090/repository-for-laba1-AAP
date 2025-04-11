using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WebApplication1.Databases;
using WebApplication1.Filters;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IScheduleService
    {
        public Task<Schedule> GetScheduleAsync(int scheduleId, CancellationToken cancellationToken);

        public Task<List<Schedule>> GetFilteredSchedules(ScheduleFilter scheduleFilter, CancellationToken cancellationToken);
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
            var schedule = _dbContext.Set<Schedule>().FirstOrDefaultAsync<Schedule>( e => (e.Id == scheduleId), cancellationToken);

           

            return schedule;
        }

        public Task<List<Schedule>> GetFilteredSchedules(ScheduleFilter scheduleFilter, CancellationToken cancellationToken)
        {  
            var schedule = _dbContext.Set<Schedule>().ToList();

            if (scheduleFilter.SubjectId != default)
            {
                schedule = schedule.Where(p => p.SubjectId == scheduleFilter.SubjectId).ToList();
            }

            if (scheduleFilter.PrepodId != default)
            {
                schedule = schedule.Where(p => p.PrepodId == scheduleFilter.PrepodId).ToList();
            }

            if (scheduleFilter.CafedraId != default)
            {
                schedule = schedule.Where(p => p.Prepod.CafedraId == scheduleFilter.CafedraId).ToList();
            }

            return Task.FromResult(schedule);
        }
    }
}
