using CiCdApp.Main;
using Xunit;

namespace CiCdApp.Tests;
public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        var calc = new Calculator();
        var result = calc.Add(2, 2);
        Assert.Equal(4, result);
    }
}