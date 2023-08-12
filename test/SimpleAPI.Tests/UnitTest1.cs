using System.Reflection;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController controller = new ValuesController();
    [Fact]
    public void GetReturnMyCohort()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("August Cohort", returnValue.Value);
    }

    [Fact]
    public void Test1()
    {

    }
}