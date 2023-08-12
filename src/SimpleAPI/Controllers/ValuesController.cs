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
        return new string[] {"November", "Graduates"};
    }

    //GEt api/values/id
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "November Graduates";
    }
}