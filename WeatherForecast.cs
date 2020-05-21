using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViralExposure
{
    [ApiController]
    [Route("[controller]")]
    public class RunIntakeController : ControllerBase
    {
        private readonly CovidIntake intake;
        public RunIntakeController(CovidIntake intake)
        {
            this.intake = intake;
        }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        [HttpGet]
        public async Task<IActionResult> RunJob() 
        {
            await intake.RunJob();
            return Ok();
        }
    }
}
