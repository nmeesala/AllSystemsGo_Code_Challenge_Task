namespace AllSystemsGo_Code_Challenge_Task.Calculator;

public partial class Calculator : ICalculator
{
    private readonly AppSettings _appSettings;
    private readonly Extensions _extensions;

    public Calculator(AppSettings appSettings, Extensions extensions)
    {
        _appSettings = appSettings;
        _extensions = extensions;
    }
}
