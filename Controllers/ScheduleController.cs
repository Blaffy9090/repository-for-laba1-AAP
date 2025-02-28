﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/ScheduleController")]
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

        [HttpGet]
        [Route("/{scheduleId}")]
        public async Task<IActionResult> GetSchedule(int scheduleId, CancellationToken cancellationToken)
        {
            var schedule = await _scheduleService.GetScheduleAsync(scheduleId, cancellationToken);

            if (schedule != null)
            {
                return Ok(schedule);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("GetFilteredSchedule")]
        public async Task<IActionResult> GetFilteredSchedulesTask(ScheduleFilter scheduleFilter, CancellationToken cancellationToken)
        {
            var schedule = await _scheduleService.GetFilteredSchedules(scheduleFilter, cancellationToken);

            return Ok(schedule);
        }
    }
}
