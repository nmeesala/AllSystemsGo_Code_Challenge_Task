namespace AllSystemsGo_Code_Challenge_Task.Calculator;

public partial class Calculator : ICalculator
{
    public int Add(string input)
    {
        List<int> numbers;

        if (string.IsNullOrWhiteSpace(input))
            return 0;

        var delimiters = new List<string> { ",", @"\n" };

        try
        {
            numbers = _extensions.SplitNumbers(input, delimiters);
        }
        catch (ArgumentException ex)
        {
            throw;
        }

        return numbers.Sum();
    }
}