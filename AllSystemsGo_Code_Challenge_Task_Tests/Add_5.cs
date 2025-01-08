using AllSystemsGo_Code_Challenge_Task.Calculator;

namespace AllSystemsGo_Code_Challenge_Task_Tests;

public partial class AddTest
{
    [Fact]
    public void Add_NumbersGreaterThan1000_Ignored()
    {
        Assert.Equal(8, calculator.Add("2,1001,6"));
    }

    [Fact]
    public void Add_NumbersGreaterThan1000_Accounted_Config_Set()
    {
        _appSettings.Number_Greater_Than = 1001;
        calculator = new Calculator(_appSettings,extensions);

        Assert.Equal(1008, calculator.Add("2,1000,6"));
    }
}
