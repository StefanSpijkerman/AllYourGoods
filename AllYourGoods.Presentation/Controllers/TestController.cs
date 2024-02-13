using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AllYourGoods.Presentation.Controllers;

[Route("[controller]")]
public class TestController : ApiBase
{
    public TestController(IMediator mediator) 
        : base(mediator)
    {
    }
    
    [HttpGet("/Test")] 
    public IActionResult GetTest()
    {
        return Ok("Test");
    }
}