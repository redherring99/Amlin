using DJAmlin.Modules;
using DRNJ.LoggerExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DJAmlin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RockAPI : ControllerBase
    {
        #region Properties/members 

        private ILogger<RockAPI> _logger;

        private IRockGenerator generator;


        #endregion
        #region Constructor
        public RockAPI(ILogger<RockAPI> logger, IRockGenerator gen)
        {
            this._logger = logger;
            this.generator = gen;
        }

        #endregion
        /// <summary>
        /// Get Rock/Paper/Scissors - randomly generated
        /// 
        /// Used so Ajax call can retrieve computer generated value
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/Amlin/Get")]
        public string Get()
        {
            var res = this.generator.Generate();
            this._logger.LogDebugMsg("Returning : ", res);
            return res;
        }
    }
}
