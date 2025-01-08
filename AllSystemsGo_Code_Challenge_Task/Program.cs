using AllSystemsGo_Code_Challenge_Task.Calculator;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = Registrations.CreateService();
        ICalculator calculator = services.GetRequiredService<ICalculator>();
        Console.WriteLine("Enter numbers to calculate, or press Ctrl+C to exit:");

        while (true)
        {
            try
            {
                string input = Console.ReadLine();
                int result = calculator.Add(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}