using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]

public class ValuesController : ControllerBase
{
    // Get api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"values1", "values2"};
    }

    //GEt api/values/id
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "August Cohort";
    }
}