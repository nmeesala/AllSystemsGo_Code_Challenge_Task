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

    public string ExtractCustomDelimiters(string input, List<string> delimiters)
    {
        if (input.StartsWith("//"))
        {
            var delimiterSectionEnd = input.IndexOf(@"\n");
            var delimiterSection = input[2..delimiterSectionEnd];

            if (delimiterSection.StartsWith("["))
            {
                var matches = Regex.Matches(delimiterSection, "\\[(.*?)\\]");
                foreach (Match match in matches)
                {
                    delimiters.Add(match.Groups[1].Value);
                }
            }
            else
            {
                delimiters.Add(delimiterSection);
            }

            input = input[(delimiterSectionEnd)..];
        }

        return input;
    }
    public void ValidateNumbers(List<int> numbers)
    {
        if (_appSettings.Deny_Negative)
        {
            var negatives = numbers.Where(n => n < 0).ToList();
            if (negatives.Any())
            {
                throw new Exception($"Negative numbers are not allowed: {string.Join(", ", negatives)}");
            }
        }
    }
}
