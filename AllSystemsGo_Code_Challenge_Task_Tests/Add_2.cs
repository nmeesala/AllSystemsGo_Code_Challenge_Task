using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSystemsGo_Code_Challenge_Task_Tests;

public partial class AddTest
{
    [Fact]
    public void Add_More_Than_2_ThrowsException_False()
    {
        var result = calculator.Add("1,2,3,4,5,6,7,8,9,10,11,12");

        Assert.Equal(78, result);
    }
}
