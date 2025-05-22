using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Databases;
using Moq;
using WebApplication1.Models;
using WebApplication1.Controllers;
using WebApplication1.Interfaces;
namespace WebApplication1.Tests
{
    public class IntegrationTests2
    {
        public readonly DbContextOptions<PrepodDbContext> prepodDbContext;

        public IntegrationTests2()
        {
            prepodDbContext = new DbContextOptionsBuilder<PrepodDbContext>().UseInMemoryDatabase( databaseName: "Proekt_prakticum").Options;
        }

        [Fact]
        public async Task GetSchedule()
        {
            var db = new PrepodDbContext(prepodDbContext);
            var service = new ScheduleService(db);
            var ctrl = new ScheduleController(service);

            var ll = await ctrl.GetSchedule(4, new CancellationToken());

            Assert.NotNull(ll);
        }

        [Fact]
        public async Task GetFilteredSchedules()
        {
            var db = new PrepodDbContext(prepodDbContext);
            var service = new ScheduleService(db);
            var ctrl = new ScheduleController(service);

            var ll = await ctrl.GetFilteredSchedulesTask(new Filters.ScheduleFilter { SubjectId = 4}, new CancellationToken());

            Assert.NotNull(ll);
        }
    }
}
