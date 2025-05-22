using WebApplication1.Models;
using Xunit;
namespace WebApplication1.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test1()
        {
            var schd =  new Subject()
            {
                SubjectName = "Proga"
            };

            Assert.True(schd.IsEmptyName());
        }

        [Fact]
        public void Test2()
        {
            var schd = new Subject()
            {
                SubjectName = ""
            };

            Assert.True(schd.IsEmptyName());
        }
    }
}
