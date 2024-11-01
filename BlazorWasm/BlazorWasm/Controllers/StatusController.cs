using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Status: OK");
    }
    
    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        return Ok("Status: OK for id " + id);
    }
}