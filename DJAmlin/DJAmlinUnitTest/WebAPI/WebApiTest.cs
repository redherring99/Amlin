using DJAmlin.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using DJAmlinUnitTest.Builder;
using FluentAssertions;
using Xunit;

namespace DJAmlinUnitTest.WebAPI
{
    public class WebApiTest
    {
        [Fact]
        public void TestRandomRockPaperScissors()
        {
            // *************************************************************************************************
            // Arrange
            // *************************************************************************************************

            var fakeLogger = new FakeLoggerBuilder().Build<RockAPI>();
            var fakeGenerator = new FakeRockerGeneratorBuilder().WithResult("Test").Build();
            var controller = new RockAPI(fakeLogger,fakeGenerator);

            // *************************************************************************************************
            // Act
            // *************************************************************************************************

            string res = controller.Get();

            // *************************************************************************************************
            // Assert
            // *************************************************************************************************

            res.Should().Be("Test");
        }
    }
}
