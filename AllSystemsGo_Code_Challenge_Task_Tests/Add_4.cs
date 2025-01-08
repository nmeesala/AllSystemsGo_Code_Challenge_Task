using AllSystemsGo_Code_Challenge_Task.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSystemsGo_Code_Challenge_Task_Tests;

public partial class AddTest
{
    [Fact]
    public void Add_NegativeNumbers_ThrowsException()
    {
        Action act = () => calculator.Add("4,-3,-5");

        Exception exception = Assert.Throws<Exception>(() => act());

        Assert.Equal("Negative numbers are not allowed: -3, -5", exception.Message);
    }

    [Fact]
    public void Add_NegativeNumbers_Dont_ThrowsException_Confi_Set_False()
    {
        _appSettings.Deny_Negative = false;

        calculator = new Calculator(_appSettings, extensions);

        Assert.Equal(-5,calculator.Add("1,-4,-5,3"));
    }
}
