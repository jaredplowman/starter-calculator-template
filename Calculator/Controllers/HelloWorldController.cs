using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculator.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{        
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public HelloWorld GetHelloWorld()
    {
        return new HelloWorld()
        {
            Title = "Hello world!"
        };            
    }
}