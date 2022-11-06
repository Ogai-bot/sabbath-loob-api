using Microsoft.AspNetCore.Mvc;

namespace SabbathLoop.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TestsController : ControllerBase
{
    public TestsController()
    {
    }

    [HttpGet]
    public string Test1()
    {
        return "Running!!";
    }
}
