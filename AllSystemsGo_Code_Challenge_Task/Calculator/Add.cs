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
            _extensions.ValidateNumbers(numbers);
        }
        catch (ArgumentException ex)
        {
            throw;
        }
        catch (Exception)
        {
            throw;
        }

        //Logic to check and invalidate any number greater than config setting and return 0
        //for the same
        numbers = numbers.Select(n => n > _appSettings.Number_Greater_Than ? 0 : n).ToList();
        Console.WriteLine($"{string.Join('+', numbers)} = {numbers.Sum()}");

        return numbers.Sum();
    }
}