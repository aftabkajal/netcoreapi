using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreApi.CommandContext.Commands;
using NetCoreApi.HttpContext;

namespace NetCoreApi.WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NetCoreCommandController : ControllerBase
    {
        private const string QueueName = "NetCoreQueue";
        private readonly ILogger<NetCoreCommandController> _logger;
        public NetCoreCommandController(ILogger<NetCoreCommandController> logger)
        {
            this._logger = logger;
        }
        // GET api/values
        [HttpGet]
        public CommandResponse CreateDemo([FromBody]DemoCommand command)
        {
            var response = new CommandResponse();
            this._logger.LogInformation($"Command Arrived with name {nameof(DemoCommand)}");
            
            return response;
        }        
    }
}
