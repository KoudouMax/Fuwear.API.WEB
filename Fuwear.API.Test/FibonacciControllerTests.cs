using Fuwear.API.UI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Fuwear.API.Test;

public class FibonacciControllerTests
{
    private readonly FibonacciController _controller;
    public FibonacciControllerTests()
    {
        _controller = new FibonacciController();
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(5, 5)]
    [InlineData(10, 55)]
    [InlineData(20, 6765)]
    public void ShouldReturnExpectedValue(int n, int expected)
    {
        var result = _controller.Get(n);
        OkObjectResult? okResult = result as OkObjectResult;

        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result);
        Assert.NotNull(okResult?.Value);
        Assert.Equal(200, okResult.StatusCode);
        Assert.Equal(expected, okResult.Value);
    }

    [Theory]
    [InlineData(200, "n doit être compris entre 1 et 100.")]
    public void ShouldThrowException_WhenNIsOutOfRange(int n, string expected)
    {
        var result = _controller.Get(n);
        BadRequestObjectResult? badResult = result as BadRequestObjectResult;

        Assert.NotNull(result);
        Assert.IsType<BadRequestObjectResult>(result);
        Assert.NotNull(badResult?.Value);
        Assert.Equal(400, badResult.StatusCode);
        Assert.Equal(expected, badResult.Value);
    }

}
