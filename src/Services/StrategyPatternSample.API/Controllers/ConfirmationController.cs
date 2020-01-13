using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StrategyPatternSample.API.Models;
using StrategyPatternSample.API.Services;

namespace StrategyPatternSample.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfirmationController : ControllerBase
    {

        private readonly Dictionary<Channel,IConfirmationService> iConfirmationServices;


        public ConfirmationController(IEnumerable<IConfirmationService> iConfirmationServices)
        {
            this.iConfirmationServices = iConfirmationServices.ToDictionary(service => service.Channel);
        }

        [HttpGet("{type}/{identifiant}")]
        public NoContentResult Get(Channel type, string identifiant)
        {
            iConfirmationServices[type].SendNotification(identifiant);

            return NoContent();
        }
    }
}
