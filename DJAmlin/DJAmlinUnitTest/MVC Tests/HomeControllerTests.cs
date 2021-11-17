using DJAmlin.Controllers;
using DJAmlin.Models;
using DJAmlinUnitTest.Builder;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DJAmlinUnitTest.MVC_Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void TestUserVComputer()
        {
            // *************************************************************************************************
            // Arrange
            // *************************************************************************************************

            var fakeLogger = new FakeLoggerBuilder().Build<HomeController>();
            var fakeGenerator = new FakeRockerGeneratorBuilder().WithResult(Definitions.Scissors).Build();
            var controller = new HomeController(fakeLogger, fakeGenerator);

            GameResult userSelection = new GameResult();
            userSelection.Player1Choice = Definitions.Rock;
            // *************************************************************************************************
            // Act
            // *************************************************************************************************

            var res = controller.MVCResult(userSelection);

            // *************************************************************************************************
            // Assert
            // *************************************************************************************************

            //-------------
            // Yuck Recast(s) |
            //-----------------
            ((GameResult)(((ViewResult)res).Model)).WinningPlayer.Should().Be(Winner.Player1);
        }
    }
}
