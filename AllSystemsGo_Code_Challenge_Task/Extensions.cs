using System.Text.RegularExpressions;

namespace AllSystemsGo_Code_Challenge_Task;

public class Extensions
{
    private readonly AppSettings _appSettings;

    public Extensions(AppSettings appSettings)
    {
        _appSettings = appSettings;
    }
    public List<int> SplitNumbers(string input, List<string> delimiters)
    {
        var splitNumbers = Regex.Split(input, string.Join("|", delimiters.Select(Regex.Escape)));

        var numbers = new List<int>();

        foreach (var number in splitNumbers)
        {
            if (int.TryParse(number, out var parsedNumber))
            {
                numbers.Add(parsedNumber);
            }
            else
            {
                numbers.Add(0);
            }
        }

        return numbers;
    }
}
