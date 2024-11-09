using Microsoft.AspNetCore.Mvc;
using vtpartssite.Service;

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
    }
}
