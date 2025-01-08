namespace AllSystemsGo_Code_Challenge_Task_Tests;

public partial class AddTest
{
    [Fact]
    public void Add_CustomDelimiterMultipleChars_ReturnsSum()
    {
        Assert.Equal(66, calculator.Add(@"//[***]\n11***22***33"));
    }

    [Fact]
    public void Add_MultipleCustomDelimiters_ReturnsSum()
    {
        Assert.Equal(110, calculator.Add(@"//[*][!!][r9r]\n11r9r22*hh*33!!44"));
    }
}
