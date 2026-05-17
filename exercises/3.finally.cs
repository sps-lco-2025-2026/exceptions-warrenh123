// exercise 3
Console.Write("Enter a number");
try
{
    int n = int.Parse(Console.ReadLine()!);
    string output = n%2 == 0 ? "even" : "odd";
    Console.WriteLine(output);
}
catch(FormatException e)
{
    Console.WriteLine($"Please enter an integer, {e.Message}");
}
catch(OverflowException e)
{
    Console.WriteLine($"Please enter a smaller number, {e.Message}");
}
finally
{
    Console.WriteLine("Thank you for using the program.");
}