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
        public async Task GetAllSubjects()
        {
            var db = new PrepodDbContext(prepodDbContext);
            var service = new SubjectService(db);
            var ctrl = new SubjectController(service);

            var ll = await ctrl.GetAll( new CancellationToken());

            Assert.NotNull(ll);
            if (ll != null)
                Assert.NotEmpty((List<Subject>)ll);
        }
    }
}
