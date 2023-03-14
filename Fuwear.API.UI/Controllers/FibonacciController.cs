using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fuwear.API.UI.Controllers;

[ApiController]
[Route("[controller]")]
public class FibonacciController : ControllerBase
{
    [HttpGet("{n}")]
    public IActionResult Get(int n) {

        int result = Fibonacci(n);

        if (result == -1) {
            return BadRequest("n doit être compris entre 1 et 100.");
        }

        return Ok(result);
    }

    private int Fibonacci(int n)
    {
        if (n < 0 || n > 100) return -1;

        if (n == 0) return 0;
        else if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }


}

