using FizzBuzz.Models;
using FizzBuzz.Service;
using Microsoft.AspNetCore.Mvc;

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
        [ProducesResponseType(typeof(List<Response>), 200)]
        public async Task<IActionResult> Execute([FromQuery] List<string> inputs)
        {

            //Controller should be as clean as possible. its ideal to not to write unit test against controllers, so all the business logic must be offloaded to various services i.e _fizzBuzzService.
            var response = await _fizzBuzzService.FetchResults(inputs);
            return Ok(response);

        }

    }
}
