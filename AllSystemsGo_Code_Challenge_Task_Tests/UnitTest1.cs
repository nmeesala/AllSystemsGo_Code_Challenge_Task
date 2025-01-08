using AllSystemsGo_Code_Challenge_Task.Calculator;
using AllSystemsGo_Code_Challenge_Task;
using Moq;

namespace AllSystemsGo_Code_Challenge_Task_Tests
{
    public class AddTest
    {
        private Extensions extensions;
        private ICalculator calculator;
        private readonly AppSettings _appSettings = new()
        {
            Deny_Negative = true,
            Number_Greater_Than = 1000,
            Delimators = null
        };
         
        public AddTest()
        {
            extensions = new Extensions(_appSettings);
            calculator = new Calculator(_appSettings, extensions);
        }

        [Fact]
        public void Add_EmptyString_ReturnsZero()
        {
            Assert.Equal(0, calculator.Add(""));
        }

        [Fact]
        public void Add_SingleNumber_ReturnsNumber()
        {
            Assert.Equal(5, calculator.Add("5"));
        }

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.Equal(9, calculator.Add("4,5"));
        }

        [Fact]
        public void Add_InvalidNumber_TreatsAsZero()
        {
            Assert.Equal(4, calculator.Add("4,tytyt"));
        }

        [Fact]
        public void Add_More_Than_2_ThrowsException()
        {
            Action act = () => calculator.Add("4, 3,tytyt");

            ArgumentException exception = Assert.Throws<ArgumentException>(() => act());

            Assert.Equal("Input valid for <=2 numbers", exception.Message);
        }
    }
}
