using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ViralExposure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExposureController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ExposureController> _logger;

        public ExposureController(ILogger<ExposureController> logger)
        {
            _logger = logger;
        }

    }
}
