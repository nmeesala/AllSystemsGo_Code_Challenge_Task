using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSystemsGo_Code_Challenge_Task_Tests;

public partial class AddTest
{
    [Fact]
    public void Add_CustomDelimiterSingleChar_ReturnsSum()
    {
        Assert.Equal(7, calculator.Add(@"//#\n2#5"));
        Assert.Equal(102, calculator.Add(@"//,\n2,ff,100"));
    }
}
