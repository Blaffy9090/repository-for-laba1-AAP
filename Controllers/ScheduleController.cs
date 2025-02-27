using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly ILogger<ScheduleController> _logger;
        private readonly IScheduleService _scheduleService;

        public ScheduleController(ILogger<ScheduleController> logger, IScheduleService scheduleService) 
        {
            _logger = logger;
            _scheduleService = scheduleService;
        }

        [HttpPost(Name = "GetSchedule")]
        public async Task<IActionResult> GetSchedule(int scheduleId, CancellationToken cancellationToken)
        {
            var schedule = await _scheduleService.GetScheduleAsync(scheduleId, cancellationToken);

            return Ok(schedule);
        }

        [HttpPost(Name = "GetFilteredSchedules")]
        public async Task<IActionResult> GetFilteredSchedules(ScheduleFilter scheduleFilter, CancellationToken cancellationToken)
        {
            var schedule = await _scheduleService.GetFilteredSchedules(scheduleFilter, cancellationToken);

            return Ok(schedule);
        }
    }
}
