using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fuwear.API.UI.Controllers;

[ApiController]
[Route("[controller]")]
public class ActionController : ControllerBase
{
    #region Static Data
    private static readonly string[] _actions = new[]
    { "AMZN", "CACC", "EQIX", "GOOG", "ORLY", "ULTA" };

    private static readonly double[,] _prices = new[,]
    {
        { 12.81, 11.09, 12.11, 10.93, 9.83, 8.14 },

        { 10.34, 10.56, 10.14, 12.17, 13.1, 11.22 },

        { 11.53, 10.67, 10.42, 11.88, 11.77, 10.21 }
    };
    #endregion

    [HttpGet()]
    public ActionResult<models.Action> GetAction() {
        var averages = Enumerable.Range(0, _actions.Length)
            .Select(i => new { Name = _actions[i], AvgPrice = (double)Enumerable.Range(0, 3).Select(j => _prices[j, i]).Average() })
            .OrderByDescending(a => a.AvgPrice);

        models.Action action = new models.Action
        {
            Name = averages.First().Name,
            AvgPrice = averages.First().AvgPrice
        };

        return Ok(action);
    }

}

