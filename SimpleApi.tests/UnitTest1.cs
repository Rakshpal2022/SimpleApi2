using Xunit;
using SimpleApi.Controllers;
namespace SimpleApi.tests;

public class UnitTest1
{
     ValuesController objValueController=new ValuesController();
    [Fact]
    public void Test1()
    {
       var ctr=objValueController.Get(1);
        Assert.Equal("Raksh Pal",ctr);
    }
}