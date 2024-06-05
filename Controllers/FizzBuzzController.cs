using FizzBuzz.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FizzBuzz.Controllers
{
    [Route("api")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;
        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpGet]
        [Route("execute")]
        public async Task<IActionResult> Execute([FromQuery] List<string> inputs)
        {
            var response = await _fizzBuzzService.FetchResults(inputs);
            return Ok(response);
        }

    }
}
