using System.Dynamic;

// program below...
Console.Write("Enter temperature: ");

double CelsiusToFahrenheit(double celsius)
{
    if(input < -273.15)
    {
        throw new TemperatureException();
    }
    return celsius*1.8+32;
}

try
{
    Console.Write("Enter temperature in celsius: ");
    double input = double.Parse(Console.ReadLine());
    Console.WriteLine(CelsiusToFahrenheit(input));
}
catch(TemperatureException e)
{
    Console.WriteLine($"The temperature {e.AttemptedTemp} is below absolute zero(minimum: -273.15)");
}
catch(FormatException)
{
    Console.WriteLine("Please enter a number");
}


//Class
class TemperatureException : Exception
{
    private int _attemptedTemp;
    public int AttemptedTemp => _attemptedTemp;

    public TemperatureException() : base("Temperature cannot drop below absolute zero"){ }

    public TemperatureException(double AttemptedTemp, string message): base(message)
    {
        _attemptedTemp = AttemptedTemp;
    }
}


