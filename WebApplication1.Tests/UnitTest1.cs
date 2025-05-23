﻿using WebApplication1.Models;
using Xunit;
namespace WebApplication1.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var schd = new Schedule() {
                Prepod = new Prepod()
                {
                    FirstName = "Petrov"
                },
            };

            Assert.True(schd.IsValidPrepod());
        }
        [Fact]
        public void Test2()
        {
            var schd = new Schedule()
            {
                Subject = new Subject()
                {
                    SubjectName = "Proga"
                }
            };

            Assert.True(schd.IsValidSubject());
        }
        [Fact]
        public void Test3()
        {
            var schd = new Schedule()
            {
                Prepod = new Prepod()
                {
                    FirstName = "Petrov"
                },
                Subject = new Subject()
                {
                    SubjectName = "Proga"
                }
            };

            Assert.True(schd.IsValidSchedule());
        }
    }
}
