using Microsoft.AspNetCore.Mvc;

namespace FamilyTree.Api.Controllers;

[ApiController] //says this class is an API Conntroller
[Route("api/[controller]")] //says use the controller name to create the route this route becomes /api/health
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { status = "ok "});
    }
}