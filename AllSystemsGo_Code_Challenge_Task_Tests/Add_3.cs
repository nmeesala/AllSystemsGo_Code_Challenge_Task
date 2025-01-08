using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSystemsGo_Code_Challenge_Task_Tests;

public partial class AddTest
{
    [Fact]
    public void Add_NewlineDelimiter_ReturnsSum()
    {
        Assert.Equal(6, calculator.Add(@"1\n2,3"));
    }

    [Fact]
    public void Add_All_NewlineDelimiter_ReturnsSum()
    {
        Assert.Equal(10, calculator.Add(@"1\n2\n3\n4"));
    }
}
