using Microsoft.AspNetCore.Mvc;
using vtpartssite.Interfaces;

namespace vtpartssite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly INewService _newService;

        public HelloWorldController(INewService newService)
        {
            _newService = newService;
        }

        [HttpGet("get-service-message")]
        public IActionResult GetServiceMessage()
        {
            var message = _newService.GetMessage();
            return Ok(message);
        }

        [HttpGet("get-repository-message")]
        public IActionResult GetMessageFromRepository()
        {
            var message = _newService.GetMessageFromRepository();
            return Ok(message);
        }

    }
}
