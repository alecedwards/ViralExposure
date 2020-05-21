using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace ViralExposure {
    [ApiController]
    [Route("[controller]")]
    public class CovidInfoController : ControllerBase {

        [HttpGet]
        public IActionResult Get()
        {
            IAsyncEnumerable<TownCovidInfo> results;
            using (var context = new CovidContext())
            {
                results = context.TownCovidInformation.AsAsyncEnumerable();
            }
             
             return Ok(results);
        }
    }
}