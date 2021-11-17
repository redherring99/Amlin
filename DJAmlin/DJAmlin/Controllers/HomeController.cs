using DJAmlin.Models;
using DJAmlin.Modules;
using DRNJ.LoggerExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DJAmlin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private IRockGenerator generator;

        public HomeController(ILogger<HomeController> logger, IRockGenerator gen)
        {
            _logger = logger;
            this.generator = gen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //-----------------------------------------
            // Noddy example of loggin in a method to |
            // aid debugging                          |
            //-----------------------------------------
            this._logger.LogDebugMsg("Home Index called");
            return View(new GameResult());
        }

        /// <summary>
        /// Simple MVC based postback game + result
        /// </summary>
        /// <param name="userSelection"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult MVCResult(GameResult userSelection)
        {
            //-----------------------------------------
            // Noddy example of loggin in a method to |
            // aid debugging                          |
            //-----------------------------------------
            this._logger.LogDebugMsg("Home Index called. Choice ", userSelection.Player1Choice);

            //-
            // 

            userSelection.Player2Choice = generator.Generate();
            userSelection.WinningPlayer = generator.CalculateWinner(userSelection.Player1Choice,userSelection.Player2Choice);

            return View("GameResult", userSelection);
        }

        /// <summary>
        /// Computer Plays against itself
        /// </summary>
        /// <returns></returns>
        public IActionResult ComputerPlaysComputer()
        {
            var result = new GameResult();

            result.Player1Choice = generator.Generate();
            result.Player2Choice = generator.Generate();
            result.WinningPlayer = generator.CalculateWinner(result.Player1Choice, result.Player2Choice);

            return View("ComputerPlaysComputer", result);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
