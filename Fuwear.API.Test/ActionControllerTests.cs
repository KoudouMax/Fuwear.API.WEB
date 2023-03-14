using System;
using System.Reflection;
using Fuwear.API.UI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Fuwear.API.Test;

public class ActionControllerTests
{
    private readonly ActionController _controller;
    public ActionControllerTests()
	{
        _controller = new ActionController();
    }

    [Fact]
    public void ShouldReturn5_When_n_Equal5() {
        UI.models.Action expected = new UI.models.Action
        {
            Name = "GOOG",
            AvgPrice = 11.660000000000002
        };

        var result = _controller.GetAction();
        OkObjectResult? okResult = result.Result as OkObjectResult;
        var action = okResult?.Value as UI.models.Action;


        Assert.NotNull(result);
        Assert.NotNull(okResult?.Value);
        Assert.Equal(200, okResult.StatusCode);
        Assert.Equal(expected.Name, action?.Name);
        Assert.Equal(expected.AvgPrice, action?.AvgPrice);
    }
}

