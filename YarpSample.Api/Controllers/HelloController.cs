using Microsoft.AspNetCore.Mvc;

namespace YarpSample.Api.Controllers;

[ApiController]
public class HelloController : ControllerBase
{
    [HttpGet]
    [Route("api/hello")]
    public ActionResult Get() { return Ok("Hello"); }
}