Console.Write("Enter a number: ");

try
{
    int n = int.Parse(Console.ReadLine()!);
    Console.WriteLine(100 / n); 
}
catch(FormatException e)
{
    Console.WriteLine($"Enter an integer, {e.Message}");
}
catch(OverflowException e)
{
    Console.WriteLine($"Number is too big, {e.Message}");
}
finally
{
    Console.WriteLine("Calculation complete.");
}